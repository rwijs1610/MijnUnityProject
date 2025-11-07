// ...existing code...
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    // Scores for two teams: A and B
    private int scoreA = 0;
    private int scoreB = 0;

    // Optional: enable/disable logging to Console
    public bool logToConsole = true;

    // Points added when pressing keys A/B (can be changed in Inspector)
    public int pointsPerKey = 1;

    // Tracks whether the game has ended
    private bool gameEnded = false;

    // Voeg punten toe aan team "A" of "B" (case-insensitive)
    public void AddPoints(string team, int points)
    {
        if (gameEnded) return; // ignore points after game end
        if (string.IsNullOrEmpty(team)) return;
        string t = team.Trim().ToUpperInvariant();

        if (t == "A")
            scoreA += points;
        else if (t == "B")
            scoreB += points;
        else
        {
            if (this.logToConsole) Debug.LogWarning($"AddPoints: unknown team '{team}'");
            return;
        }

        if (this.logToConsole)
            Debug.Log($"Added {points} points to Team {t}. Scores => A: {scoreA}, B: {scoreB}");
    }

    // Update checks for key presses and adds points to the corresponding team
    void Update()
    {
        if (gameEnded)
        {
            // optional: allow restart with R
            if (Input.GetKeyDown(KeyCode.R))
            {
                ResetScores();
                gameEnded = false;
                Time.timeScale = 1f;
                if (logToConsole) Debug.Log("Game restarted.");
            }
            return;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            AddPoints("A", pointsPerKey);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            AddPoints("B", pointsPerKey);
        }

        // W ends the game, logs the winner and pauses the game
        if (Input.GetKeyDown(KeyCode.W))
        {
            EndGame();
        }
    }

    // Geef de score van team "A" of "B" terug
    public int GetScore(string team)
    {
        if (string.IsNullOrEmpty(team)) return 0;
        string t = team.Trim().ToUpperInvariant();

        int value = t == "A" ? scoreA : t == "B" ? scoreB : 0;
        if (this.logToConsole)
            Debug.Log($"GetScore('{team}') => {value}");
        return value;
    }

    // Bepaal de winnaar: "A", "B" of "Tie"
    public string GetWinner()
    {
        string winner = DetermineWinner();
        if (this.logToConsole)
            Debug.Log($"GetWinner() => {winner} (A={scoreA}, B={scoreB})");
        return winner;
    }

    // Internal helper to determine winner without logging
    private string DetermineWinner()
    {
        if (scoreA == scoreB) return "Tie";
        return scoreA > scoreB ? "A" : "B";
    }

    // Ends the game: logs winner and pauses time
    public void EndGame()
    {
        if (gameEnded) return;
        gameEnded = true;
        string winner = DetermineWinner();
        if (logToConsole)
        {
            Debug.Log($"Game ended. Winner: {winner} (A={scoreA}, B={scoreB})");
        }
        Time.timeScale = 0f; // pause the game
    }

    // Reset scores voor beide teams
    public void ResetScores()
    {
        scoreA = 0;
        scoreB = 0;
        if (this.logToConsole) Debug.Log("Scores reset. A=0, B=0");
    }
}
// ...existing code...