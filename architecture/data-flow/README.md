# 📊 [B] Data-Flow Architectural Style

**Focus**: Not where data is stored, but how it flows.  
Systems are structured as chains of transformations or stages: each stage receives input, processes it, and passes it along.

Ideal for continuous processing, reactive systems, or streaming pipelines.

---

## 🔶 [B/1] [Pipe-and-Filter](./pipe-and-filter.md)

- **Year**: 1970s
- **Creator**: Douglas McIlroy (UNIX)
- **Description**: Data is transformed through a sequence of independent filters connected by pipes. Each filter performs a single operation and sends the output to the next.
- **When to use**: Linear data flow (e.g. ETL, text processing)
- **When not to use**: Conditional logic or complex control flow
- **Examples**: UNIX pipelines, ETL tools, compilers
- **Pros**: Modular, supports natural parallelism
- **Cons**: Error handling across stages can be difficult
- **References**: Wikipedia, GeeksforGeeks, Medium

**Evaluation**:
- Ease: ★★★★☆
- Scalability: ★★★☆☆
- Performance: ★★★★☆
- Adaptability: ★★☆☆☆
- Resilience: ★★☆☆☆
- Cost: ★★★★☆

**Total**: 19 / 30 → **6.33 / 10**

---

## 🔶 [B/2] [Event-Driven Architecture (EDA)](./event-driven.md)

- **Year**: 2005+
- **Creator**: Fowler, Mani Chandy
- **Description**: Components communicate via asynchronous events. Can use broker (central queue) or mediator (orchestrator) patterns.
- **When to use**: Real-time, reactive systems
- **When not to use**: When strong synchronous transactions are required
- **Examples**: Payments, IoT, Analytics, Distributed Systems
- **Pros**: Highly scalable and resilient, strong decoupling
- **Cons**: Harder to test, trace, and ensure consistency
- **References**: Wikipedia

**Evaluation**:
- Ease: ★★☆☆☆
- Scalability: ★★★★★
- Performance: ★★★★☆
- Adaptability: ★★★★☆
- Resilience: ★★★★☆
- Cost: ★★☆☆☆

**Total**: 21 / 30 → **7.00 / 10**

---

## 🔶 [B/3] [Saga Pattern](./saga-pattern.md)

- **Year**: 2016+
- **Creator**: Distributed transaction patterns
- **Description**: Manages long-lived distributed transactions through a series of local sub-transactions, each with a compensating action.
- **When to use**: When ACID transactions across services are not feasible
- **When not to use**: When a single transactional DB is possible
- **Examples**: Booking systems, E-commerce, Financial flows
- **Pros**: Eventual consistency, service decoupling, fault tolerance
- **Cons**: Compensation logic is complex, hard to test

**Evaluation**:
- Ease: ★★☆☆☆
- Scalability: ★★★★☆
- Performance: ★★★☆☆
- Adaptability: ★★★★☆
- Resilience: ★★★★☆
- Cost: ★★☆☆☆

**Total**: 20 / 30 → **6.66 / 10**

---

## 🔶 [B/4] [CQRS (Command Query Responsibility Segregation)](./cqrs.md)

- **Year**: 2010+
- **Creator**: Greg Young
- **Description**: Separates the read model (queries) and write model (commands). Often used with Event Sourcing.
- **When to use**: When read/write workloads require different scaling or modeling
- **When not to use**: For simple CRUD systems
- **Examples**: Trading systems, audit-focused apps
- **Pros**: Specialized optimization, auditability
- **Cons**: Increased complexity, eventual consistency

**Evaluation**:
- Ease: ★★☆☆☆
- Scalability: ★★★★☆
- Performance: ★★★★☆
- Adaptability: ★★★★☆
- Resilience: ★★★☆☆
- Cost: ★★★☆☆

**Total**: 20 / 30 → **6.66 / 10**

---

## 🔶 [B/5] [Reactor Pattern](./reactor-pattern.md)

- **Year**: 1995
- **Creator**: Douglas C. Schmidt (ACE framework)
- **Description**: Uses a single event loop and I/O multiplexing to handle many simultaneous requests without multithreading.
- **When to use**: High-performance servers, intensive I/O systems
- **When not to use**: Simple scenarios or CPU-heavy tasks inside the event loop
- **Examples**: Nginx, Node.js, Netty
- **Pros**: High throughput, efficient I/O resource usage
- **Cons**: Complex flow control with callbacks, not for CPU-heavy work

**Evaluation**:
- Ease: ★★☆☆☆
- Scalability: ★★★★☆
- Performance: ★★★★☆
- Adaptability: ★★★☆☆
- Resilience: ★★★☆☆
- Cost: ★★★★☆

**Total**: 20 / 30 → **6.66 / 10**

---

## 📊 Comparative Table

| Pattern                  | Ease  | Scale | Perf. | Adapt. | Resil. | Cost  |
|--------------------------|-------|--------|--------|---------|--------|--------|
| Pipe‑and‑Filter          | ★★★★☆ | ★★★☆☆ | ★★★★☆ | ★★☆☆☆  | ★★☆☆☆ | ★★★★☆ |
| Event‑Driven Architecture| ★★☆☆☆ | ★★★★★ | ★★★★☆ | ★★★★☆  | ★★★★☆ | ★★☆☆☆ |
| Saga Pattern             | ★★☆☆☆ | ★★★★☆ | ★★★☆☆ | ★★★★☆  | ★★★★☆ | ★★☆☆☆ |
| CQRS                     | ★★☆☆☆ | ★★★★☆ | ★★★★☆ | ★★★★☆  | ★★★☆☆ | ★★★☆☆ |
| Reactor Pattern          | ★★☆☆☆ | ★★★★☆ | ★★★★☆ | ★★★☆☆  | ★★★☆☆ | ★★★★☆ |

---

## ✅ License

MIT. Created with 💡 by Juan G Carmona. Contributions welcome.

---

🧭 *Part of the series: [Architectural Patterns Explained](https://jgcarmona.com/blog/architectural-patterns/)*  
✍️ *Draft article for: ["Architecture, the Hard Way"](https://jgcarmona.com/blog/architecture-the-hard-way)*