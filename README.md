# MijnUnityProject

## oefening 1.1 

![huisje](ImgGifs/Huisje.png)

**we zijn begonnen met wat kleine dingen zoals een huis bouwen dit hebben we gedaan met transform en rect tool zoals je ziet bestaat het huisje uit**
   - 4 Cubes voor de muren
   - 1 Cube voor de vloer (maak deze platter met Scale)
   - 1 Cube voor het dak (draai 45 graden)
   - 2 Cylinders voor schoorstenen
   - 1 Sphere als decoratie (zon of lamp)

---
## oefening 1.2 

![gaming profile](ImgGifs/GamingProfile1.png)

**ik ben begonnen met de voorgeschoten code en heb deze gepersonaliseerd tot wat het nu is**
- dit is waar ik mee begon 
```
void Start()
    // Gaming profiel informatie
    Debug.Log("=== GAMING PROFILE ===");
    Debug.Log("Gamer Tag: YourNameHere");
    Debug.Log("Favorite Game: Minecraft");
    Debug.Log("Gaming Platform: PC");
    Debug.Log("Hours Played Today: 3");
    Debug.Log("Current Level: 42");
    Debug.Log("Achievement Unlocked: First Script!");
    Debug.Log("==================");
```
- en dit is waar ik mee eindigde 
```
    Debug.Log("=== GAMING PROFILE ===");
    Debug.Log("Gamer Tag: luciq");
    Debug.Log("Favorite Game: Minecraft");
    Debug.Log("Gaming Platform: laptop");
    Debug.Log("Hours Played Today: 0");
    Debug.Log("Current Level: 10");
    Debug.Log("Achievement Unlocked: First Script!");
    Debug.Log("==================");
```
[de code file die ik heb gebruikt voor het draaien van het muntje](assets/scripts/CoinSpin.cs)

---
## oefening 2.1

![munt spin](Imggifs/CoinSpin.gif)

**de code die ik heb gebruikt heb ik uit me duim gezogen met behulp van ai ik heb wel nageken wat de code doet en kan de code uitleggen**

[de code file die ik heb gebruikt voor het draaien van het muntje](assets/scripts/CoinSpin.cs)

---
## oefening 2.2

![character sheet](ImgGifs/CharacterSheet.png)

**deze code is voorgeschoten door de opdracht**

hier heb ik eigenlik niets aan verandert 

[de code file die ik heb gebruikt voor het laten zien van de character sheet ](assets/scripts/PlayerStats.cs)

---

## oefening 3.1a
![balletje die stuitert](ImgGifs/BallBounce.gif)

**ik heb de bounciness verandert in een physics material die heb ik toegepast bij bijde objecten zodat de bal oneindig stuitert**
>zie hieronder

![info physics material](ImgGifs/InfoMaterial.png)

---
## oefening 3.1c
![balletje die stuitert van een muur](ImgGifs/WallBounce.gif)

**ik heb een script gemaakt dat de kleur verandert van de muur op basis van een colision** 

[de code file die ik heb gebruikt voor het laten veranderen van de kleur van de muur  ](Assets\scripts\Colision.cs)

---
## oefening 3.2
![score](ImgGifs/Score.gif)

**je ziet hier heel kort hoe die opteeld je bestuurt het door de A en B toets te gebruiken en met W dan laat hij de score zien en vertelt hij wie gewonnen heeft**

[de code file die ik heb gebruikt voor het laten veranderen van de kleur van de muur  ](Assets\scripts/ScoreCalculator.cs)

---
## oefening 4.1

![health status](ImgGifs/HealthStatus.gif)

**de code is bestuurbaar met zoals gevraagt h en j h voor damage en j voor healing**

- een if-structuur past hier goed omdat je voor elke log moet kijken of je health onder een bepaalde hoeveelheid is 

- een switch zou ook kunnen werken omdat je dan hoeveelheid health kan koppelen aan een massage 

[de code file die ik heb gebruikt voor het laten zien van de code](Assets\scripts/HealthStatus.cs)

---
## oefening 4.1b