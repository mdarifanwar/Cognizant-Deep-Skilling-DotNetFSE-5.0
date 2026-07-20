# Handson-6 : Kafka Integration with C#

## Objective

- Understand Apache Kafka Architecture.
- Learn Kafka Producer and Consumer.
- Integrate Kafka with C# Console Application.
- Integrate Kafka with C# Windows Forms Application.
- Exchange messages between multiple applications using Kafka.

---

# Software Requirements

- Windows 10/11
- .NET 8 SDK
- Visual Studio 2022
- Java JDK 17
- Apache Kafka 3.5.1
- ZooKeeper

---

# Project Structure

```
Handson-6-Kafka-Integration
│
├── KafkaChatConsole
│
├── KafkaChatWindows
│
├── Screenshots
│   ├── ZooKeeper running1.png
│   ├── ZooKeeper running2.png
│   ├── ZooKeeper running3.png
│   ├── Kafka Server running.png
│   ├── Topic created.png
│   ├── Producer window.png
│   └── Consumer window showing received messages.png
│
└── README.md
```

---

# Kafka Setup

## Step 1

Start ZooKeeper

```cmd
bin\windows\zookeeper-server-start.bat config\zookeeper.properties
```

---

## Step 2

Start Kafka Server

```cmd
bin\windows\kafka-server-start.bat config\server.properties
```

---

## Step 3

Create Kafka Topic

```cmd
bin\windows\kafka-topics.bat --create --topic chat-message --bootstrap-server localhost:9092 --partitions 1 --replication-factor 1
```

---

## Step 4

Start Producer

```cmd
bin\windows\kafka-console-producer.bat --broker-list localhost:9092 --topic chat-message
```

---

## Step 5

Start Consumer

```cmd
bin\windows\kafka-console-consumer.bat --bootstrap-server localhost:9092 --topic chat-message --from-beginning
```

---

# KafkaChatConsole

Features

- Kafka Producer
- Kafka Consumer
- Send Messages
- Receive Messages
- Console Based Chat

---

# KafkaChatWindows

Features

- Windows Forms UI
- Send Chat Messages
- Receive Chat Messages
- Kafka Producer
- Kafka Consumer

---

# Output

- ZooKeeper Running Successfully
- Kafka Server Running Successfully
- Topic Created Successfully
- Producer Sending Messages
- Consumer Receiving Messages
- Console Chat Application Working
- Windows Chat Application Working

---

# Screenshots

- ZooKeeper Running
- Kafka Server Running
- Topic Created
- Producer Window
- Consumer Window

---

# Result

Successfully implemented Kafka Integration using C# Console Application and Windows Forms Application. Messages were published and consumed successfully using Apache Kafka.