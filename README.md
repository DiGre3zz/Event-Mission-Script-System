# Mission Creation Tool

A Unity prototype demonstrating a data-driven designer-friendly mission system built around modular ScriptableObjects and event-driven interactions.

## Overview

The tool allows designers to compose missions from reusable, modular components — steps, conditions, and interactions, without touching code. A simple fetch quest is included as a demo mission:

1. Player talks to an NPC → mission starts
2. Player picks up a required item from the world (either placed manually or dropped from a chest)
3. Player returns to the NPC → mission completes and the item is removed from inventory

## Architecture

The system is built around a few key patterns:

- **Steps** define what a mission does and in what order in order. Each step is a ScriptableObject inheriting from `MissionStep`
- **Conditions** describe state to check, decoupled from step logic. Inheriting from `MissionCondition`
- **Mission Context** carries runtime state — typed variables and a set of `MissionFlagSO` flags — through the mission's execution.
- **Interactions** on world objects use a swappable `InteractionType` component pattern, allowing designers to configure per-object behavior without modifying core systems.
- **Input** is event-driven via a static C# event, decoupling input reading from interaction logic.

### Designer-friendly choices

- Mission flags are `MissionFlagSO` assets — the designer references flag assets in the Inspector rather than typing string IDs, preventing typo-driven bugs.
- Items are `ItemSO` assets that act as their own identity — the inventory uses the SO reference directly as its key.
- A generic "world item" prefab is reused for all pickups. The correct sprite and item data are applied at runtime from the referenced `ItemSO`.

## Known limitations & future improvements

This is a prototype scoped to demonstrate architectural thinking. Some choices were made that were informed by scope:

- **NPC state transitions** are handled by a hardcoded two-stage `NPCInteractionSwapper`. In a production tool, this would be generalized into a proper state machine driven by mission progress.
- **Inventory display** is currently console-log only. A real tool would need a UI layer.
- **Chest contents delivery** uses simple spawn points and drops items on the ground. A version with a selection UI is planned.
- **Custom editor tooling** — dropdowns and inspectors customization for a better designer UX.

Unity 6000.3.9f1 - MIT License
