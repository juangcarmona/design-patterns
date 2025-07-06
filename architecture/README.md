# 🏗️ Software Architecture Patterns

This section complements the article:

**📖 [30+ Software Architecture Patterns: A Practical Guide](https://jgcarmona.com/architecture-patterns)**  
> A visual-first reference for software architects, tech leads, and curious developers.

---

## 📊 Visual Overview

Below are the architecture patterns grouped by style. Click on each to explore real-world use cases, advantages, tradeoffs, and Mermaid diagrams.

### 🗃️ Data-Centered
```mermaid
graph TD
    A[Data-Centered] --> A1[Primary–Replica]
    A --> A2[Sharding]
    A --> A3[Space-Based]
    A --> A4[Blockchain]
```

### 🔄 Data-Flow
```mermaid
graph TD
    B[Data-Flow] --> B1[EDA]
    B --> B2[Saga]
    B --> B3[Pipe & Filter]
    B --> B4[CQRS]
```

### 🔁 Call-and-Return
```mermaid
graph TD
    C[Call-and-Return] --> C1[Monolith]
    C --> C2[MVC]
    C --> C3[Microservices]
    C --> C4[Broker]
    C --> C5[BFF]
```

### 🧩 Component-Based
```mermaid
graph TD
    D[Component-Based] --> D1[Hexagonal]
    D --> D2[Microkernel]
    D --> D3[ECB]
    D --> D4[Anti-Corruption]
```

### 🛡️ Infrastructure
```mermaid
graph TD
    E[Infrastructure] --> E1[Circuit Breaker]
    E --> E2[Bulkhead]
    E --> E3[Sidecar]
    E --> E4[Ambassador]
    E --> E5[Service Mesh]
```

### 🌐 Distributed
```mermaid
graph TD
    F[Distributed] --> F1[P2P]
    F --> F2[Leader Election]
    F --> F3[Strangler Fig]
    F --> F4[Micro Frontend]
```

---

## 📂 Directory Structure

Each pattern lives in its own `.md` file under its respective category. This is designed to scale and be easy to maintain. Feel free to contribute!

```
architecture/
├── data-centered/
├── data-flow/
├── call-and-return/
├── component-based/
├── infrastructure/
└── distributed/
```
---

## ✅ License

Creative Commons Attribution 4.0 International (CC BY 4.0).
You are free to share and adapt the material, even commercially — as long as you give appropriate credit.

Recommended attribution:

    “Diagrams and architectural patterns by Juan G Carmona (https://jgcarmona.com), licensed under CC BY 4.0.”

Contributions are welcome via pull requests.

See [LICENSE](/LICENSE)
