# **Car Simulator**

A simple Car Simulator project written in C# that simulates the behavior of a car used for hands on practice in unit testing. It also leverages an API to create a driver for the simulator.
The project follows the principles of DRY, polymorphism, separation of concerns, single source of truth, and utilizes dependency injection.

## Features

- Car-Simulator: This is the main console application that serves as the entry point for the car simulator.
ServiceLibrary: This library contains the core functionality of the car simulator, including classes and methods for simulating different car and driver behaviors.
- Car-SimulatorTests: This directory contains 50 MSTest unit tests for the car simulator.
- Car-SimulatorTestNUnit: This directory contains 2 NUnit unit tests for the car simulator.

## Testing

The project includes unit tests to ensure the correctness of the car simulator functionality. The tests are primarily written using MSTest, with 2 additional tests written using NUnit. The tests cover various aspects of the simulator, including Api integration test.

## Development Principles

Throughout the development of this project, the following development principles were applied:

Methods where created according to specific needs and then made into services. Using clear names in methods and variables for better readability.

Separation of Concerns: The codebase is structured to separate different responsibilities into modular components. Each component focuses on a specific functionality or concern, promoting maintainability and readability. This separation allows for easier maintenance and enhancements in the future.

Single Source of Truth: The project emphasizes maintaining a single authoritative representation of data and logic. This approach prevents inconsistencies by ensuring that there is only one place where specific data or business rules are defined and accessed throughout the application.

Dependency Injection: The project incorporates the use of dependency injection to achieve loose coupling between components. This promotes flexibility, testability, and facilitates the introduction of new features or modifications without tightly coupling them to existing code.
