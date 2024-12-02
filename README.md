# Design Patterns - State

This repository showcases an implementation of the State design pattern in C#. The code demonstrates how an object can alter its behavior when its internal state changes, making it appear as if the object has changed its class.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The State design pattern is a behavioral pattern that allows an object to change its behavior when its internal state changes. It encapsulates state-specific behavior and makes state transitions easy to manage, promoting a flexible and maintainable code structure.

## Implementation Overview
This repository provides a C# implementation of the State design pattern. Key components of the code include:

- **IState Interface**: Defines the contract for concrete states.
- **ConcreteStateA & ConcreteStateB Classes**: Implement the behavior of the `IState` interface in different ways.
- **Context Class**: Maintains a reference to a state object and delegates requests to the current state.
- **Program Class**: Demonstrates how to use the State pattern in a client application.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-State.git
```

Navigate into the project directory:

```bash
cd DesignPattern-State
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the State pattern in action.
3. Modify or extend the `Context`, `ConcreteStateA`, or `ConcreteStateB` classes to simulate different scenarios.

### Example Output:
```
Initial request handling:
State A: Handling request in State A.

Request handling after state change:
State changed to: ConcreteStateB
State B: Handling request in State B.
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

