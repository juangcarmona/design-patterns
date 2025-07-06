# 🧠 Data-Centered Architectures

This folder explores **Data-Centered architectural styles**, where a central data source acts as the backbone of the system. Components interact with this shared source to read, write, or synchronize state.

---

## 📌 Overview

In Data-Centered architectures, the core of the system is a central data repository: it can be a database, a message bus, a distributed ledger, or a shared memory grid. Every component revolves around this common nucleus — accessing or processing the data through it. This can become a bottleneck, or the primary point of coordination and truth.

---

## 🧩 Included Patterns

### [[A/1] Primary–Replica (Master–Slave)](./primary-replica.md)
- **Decade**: 2000s
- **Used by**: MySQL, PostgreSQL, etc.
- **Core idea**: A single primary node handles writes; replicas handle reads. Synchronization is usually eventual.
- **Best for**: High-read environments like e-commerce or dashboards.
- **Strengths**: Scales reads, supports availability, backup-friendly.
- **Weaknesses**: Eventual consistency, failover complexity.
- **Score**: 7.33 / 10

### [[A/2] Sharding (Partitioning)](./sharding.md)
- **Decade**: 2000s
- **Used by**: Google, Amazon, modern NoSQL DBs.
- **Core idea**: Data is split into shards handled by different nodes. Enables horizontal scaling.
- **Best for**: Large datasets, high-traffic platforms.
- **Strengths**: High scalability and performance.
- **Weaknesses**: Partitioning complexity, cross-shard ops.
- **Score**: 6.00 / 10

### [[A/3] Space-Based Architecture](./space-based.md)
- **Decade**: 2000s
- **Promoted by**: GigaSpaces
- **Core idea**: A shared, in-memory data space replaces the central DB. Replicated components interact through it.
- **Best for**: High-throughput systems like trading or gaming.
- **Strengths**: Low latency, scalable.
- **Weaknesses**: Memory-heavy, consistency challenges.
- **Score**: 6.00 / 10

### [[A/4] Blockchain (Distributed Ledger)](./blockchain.md)
- **Introduced**: 2008 (Bitcoin)
- **Creator**: Satoshi Nakamoto
- **Core idea**: Immutable distributed ledger, consensus among nodes.
- **Best for**: Cases needing trust, auditability, or decentralization.
- **Strengths**: Transparency, censorship resistance.
- **Weaknesses**: Low performance, energy cost, legal complexity.
- **Score**: 4.66 / 10

---

## 📊 Comparison Table

| Architecture           | Ease of Use | Scalability | Performance | Adaptability | Resilience | Cost    | Total | Score |
|------------------------|-------------|-------------|-------------|--------------|------------|---------|--------|--------|
| Primary–Replica        | ★★★★☆        | ★★★★☆        | ★★★★☆        | ★★★☆☆         | ★★★☆☆       | ★★★★☆    | 22     | 7.33   |
| Sharding               | ★★☆☆☆        | ★★★★★        | ★★★★★        | ★★☆☆☆         | ★★★☆☆       | ★★☆☆☆    | 18     | 6.00   |
| Space-Based            | ★★☆☆☆        | ★★★★★        | ★★★★☆        | ★★★☆☆         | ★★★☆☆       | ★★☆☆☆    | 18     | 6.00   |
| Blockchain             | ★★☆☆☆        | ★★☆☆☆        | ★★☆☆☆        | ★★☆☆☆         | ★★★★☆       | ★★☆☆☆    | 14     | 4.66   |

---

## ✅ License

Creative Commons Attribution 4.0 International (CC BY 4.0).  
Attribution required:  
> “Architectural diagrams and descriptions by Juan G Carmona (https://jgcarmona.com), licensed under CC BY 4.0.”

Contributions welcome via pull request.
