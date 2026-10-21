# Traffic Jam Assist Simulation

Unity simulation of Traffic Jam Assist (TJA), an automotive safety feature that extends adaptive cruise control for stop-and-go highway traffic.

Built for the Intro to Software Engineering class at Michigan State (CSE 435, Fall 2024). Our team of 5 worked with a retired Ford engineer as our client to spec out and simulate TJA. The rest of the team handled client communication, requirements planning and system diagrams. The simulation is built in Unity with C#.

TJA builds on Adaptive Cruise Control and Lane Keeping Assist. It only works below 65 km/h on limited access highways, and it uses radar to keep a set following distance from the vehicle ahead.

- **Project site:** [cse.msu.edu/~cse435/Projects/F2024/TJA1](https://www.cse.msu.edu/~cse435/Projects/F2024/TJA1/home.html)
- **Prototype:** [prototype page](https://www.cse.msu.edu/~cse435/Projects/F2024/TJA1/prototype.html)

## Scenarios

The simulation covers 6 scenarios. Each one has its own screen with interactive controls and dashboard feedback like warning icons and chime sequences.

1. **Highway detection:** TJA only engages on limited access highways
2. **Speed-based following:** The car tracks the target vehicle ahead and adjusts its speed
3. **Automatic disengagement:** TJA turns off above 65 km/h
4. **Stop-and-go:** Full stop and restart behavior in traffic
5. **Following distance:** Adjustable gap of 10, 15 or 20 m
6. **Radar obstruction:** How TJA responds when the sensor is blocked

## Built with

- Unity 6 (6000.0.24f1) with URP
- C#
- TextMesh Pro, ProBuilder and the Unity Input System
- ARCADE - FREE Racing Car and PROMETEO - Car Controller from the Unity Asset Store

## Running it

You can download it for Mac and Windows on the [prototype page](https://www.cse.msu.edu/~cse435/Projects/F2024/TJA1/prototype.html). You can also play on the page!

Otherwise:

1. Install Unity 6000.0.24f1 through Unity Hub
2. Clone the repo
3. In Unity Hub, click **Add** and pick the `TJAPrototype` folder
4. Open `Assets/Scenes/Main Menu.unity` and press **Play**
