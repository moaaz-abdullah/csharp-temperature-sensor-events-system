# Temperature Sensor Event System

An educational C# console application built to practice and understand advanced OOP concepts and event-driven programming in .NET.

This project simulates a simple temperature monitoring system where multiple components react automatically whenever the temperature changes.

---

## Concepts Practiced

This project focuses on learning and applying:

- Delegates
- Events
- EventHandler<T>
- Custom EventArgs
- Encapsulation
- Publisher/Subscriber Pattern
- Event-Driven Programming
- Loose Coupling
- Basic OOP Design

---

## Project Structure

### Sensor
Acts as the publisher.

- Stores the current temperature internally
- Raises an event whenever the temperature changes

### Display
Acts as a subscriber.

- Listens to temperature changes
- Displays the updated temperature on the console

### Alarm
Acts as another subscriber.

- Monitors temperature updates
- Triggers an alert when temperature exceeds a configurable threshold

### TemperatureArgs
Custom EventArgs class used to pass temperature data through the event.

---

## How It Works

1. User enters a new temperature
2. `Sensor` updates its internal state
3. `Sensor` raises the `TemperatureChanged` event
4. All subscribed classes react automatically:
   - `Display` prints the temperature
   - `Alarm` checks threshold and warns if necessary

This demonstrates how multiple subscribers can respond independently to the same event.

---

## Example Flow

```text
Temperature value?
35

The current temperature value: 35
Temperature is greater than the threshold
```

---

## Technologies Used

- C#
- .NET
- Console Application

---

## Educational Purpose

This project was created for learning purposes while studying advanced C# topics such as:

- Delegates
- Events
- Encapsulation
- Event-driven architecture

The goal is to understand how real-world systems communicate using publishers and subscribers while keeping components loosely coupled.

---

## Future Improvements

Possible future enhancements:

- Add logging system subscriber
- Add multiple sensors
- Add async event handling
- Store temperature history
- Create GUI version
- Add unit tests

---

### Moaaz Abdullah
