# 📡 Call-and-Return Architectural Styles

This style is probably the most common: one part of the system calls another and waits for a response. Whether it's a classic monolith, a modular backend, or a distributed system with APIs, it all relies on the idea that one component "commands" and another "responds". Easy to understand, but it can become fragile if coupling is not controlled.

---


### [C/1] [Monolith (N‑Tier / Layered)](./monolith.md)  
**Year**: 1995 (Three‑Tier popularized)  
**Creator**: John J. Donovan  
**Description**:  
Structured in layers (presentation, business logic, data access), all deployed as a single unit. Ideal for small apps or when complexity is limited: modified and tested as a block.

**When to use / avoid**:  
– Use when the domain is simple and teams are small.  
– Avoid with rapid growth, multiple domains or need for scalable parts.

**Use Cases**: MVPs, internal tools, low-growth systems.

**Pros**:
- Easy to implement, fewer infrastructure needs, easy to test.
- Low initial infrastructure cost.

**Cons**:
- Poor granular scalability, risk of turning into a “big ball of mud”.
- Hard to isolate and change specific areas.

**Combinable with**: modular monolith, hexagonal architecture, EDA for triggering tasks.  
**Evaluation**: Implementation Ease: ★★★★☆
- Scalability: ★★☆☆☆
- Performance: ★★★★☆
- Adaptability: ★★☆☆☆
- Resilience: ★★☆☆☆
- Cost: ★★★★★

---

### [C/2] [Modular Monolith](./modular-monolith.md)  
**Year**: Recent evolution (2010+)  
**Creator**: Gradual concept, influenced by SOA/layered modularity.  
**Description**:  
Monolith divided into internal modules with clear boundaries, but deployed as a single unit. Enables code organization and simple deployment.

**When to use / avoid**:  
– Useful to maintain modular structure without microservices overhead.  
– Not suitable when independent deployment or scaling per module is needed.

**Use Cases**: Medium apps with internal team/module separation.

**Pros**:
- Modularity without distributed system overhead, easier testing than microservices.

**Cons**:
- No failure isolation or per-module scaling.

**Combinable with**: hexagonal, CQRS, EDA.  
**Evaluation**:
- Ease: ★★★★☆
- Scalability: ★★☆☆☆
- Performance: ★★★★☆
- Adaptability: ★★★☆☆
- Resilience: ★★☆☆☆
- Cost: ★★★★☆

---

### [C/3] [MVC (Model‑View‑Controller)](./mvc.md)  
**Year**: 1978 / 1980s (SmallTalk); web-popular in 2000s  
**Creator**: Trygve Reenskaug  
**Description**:  
Separates data logic (Model), presentation (View), and flow control (Controller). Promotes modular, testable, scalable UI development.

**When to use / avoid**:  
Perfect for traditional web apps with server-side logic. Less suitable for SPAs with minimal backend load.

**Use Cases**: Web frameworks like Rails, Django, Spring MVC.

**Pros**:
- Clear separation of concerns, parallel development, good testability.

**Cons**:
- Overhead for trivial apps; distributed logic can increase complexity.

**Combinable with**: Hexagonal, BFF, EDA.  
**Evaluation**:
- Ease: ★★★★☆
- Scalability: ★★☆☆☆
- Performance: ★★★☆☆
- Adaptability: ★★★★☆
- Resilience: ★★☆☆☆
- Cost: ★★★★☆

---


### [C/4] [Backend‑For‑Frontend (BFF)](./bff.md)  

**Year**: 2015  
**Creator**: Sam Newman  
**Description**:  
Creates a dedicated microservice for each type of client (web, mobile, IoT). Acts as a middle layer that adapts payloads and streamlines communication. Improves UX and decouples frontend-backend cycles.

**When to use**: When multiple UIs evolve separately or need tailored responses.  
**When not to use**: If there's only one type of client or when complexity doesn’t justify extra services.

**Use cases**: Web + mobile apps with different needs.  
**Pros**: Optimized UX, separation of concerns, improved security.  
**Cons**: More deployments, partial duplication of logic.

**Combine with**: Microservices, API Gateway, EDA.

**Evaluation**:  
- Facilidad: ★★★☆☆
- Escalabilidad: ★★★★☆
- Rendimiento: ★★★★☆
- Adaptabilidad: ★★★★☆
- Resiliencia: ★★★☆☆
- Coste: ★★★☆☆

---

### [C/5] [SOA (Service‑Oriented Architecture)](./soa.md)  
**Year**: ~2003  
**Creators**: Thomas Erl, Michael Bell  
**Description**:  
Autonomous services with standard contracts (SOAP/WSDL). Often orchestrated. Larger in scope than microservices.

**When to use**: For enterprise integration or legacy systems.  
**When not to use**: When looking for lightweight agility.

**Use cases**: Banking, heterogeneous enterprise systems.  
**Pros**: Reusability, platform independence.  
**Cons**: XML overhead, complex testing and orchestration.

**Combine with**: EDA, stepping stone to microservices.

**Evaluation**:  
- Facilidad: ★★☆☆☆
- Escalabilidad: ★★★☆☆
- Rendimiento: ★★☆☆☆
- Adaptabilidad: ★★★☆☆
- Resiliencia: ★★★☆☆
- Coste: ★★★☆☆

---

### [C/6] [Microservices](./microservices.md)  
**Year**: 2012  
**Creators**: James Lewis, Martin Fowler, Adrian Cockcroft  
**Description**:  
Small, independently deployable services, each with its own DB and domain logic. Popularized by Netflix.

**When to use**: In large systems with high scalability needs.  
**When not to use**: In small apps or immature teams.

**Use cases**: Netflix, Amazon, Uber  
**Pros**: Granular scaling, autonomous teams, resilient isolation.  
**Cons**: Complex network logic, harder testing and consistency.

**Combine with**: DDD, EDA, CQRS, Hexagonal Architecture.

**Evaluation**:
- Facilidad: ★★☆☆☆
- Escalabilidad: ★★★★★
- Rendimiento: ★★★☆☆
- Adaptabilidad: ★★★★★
- Resiliencia: ★★★★☆
- Coste: ★★★★☆

---

### [C/7] [Broker](./broker.md)  
**Year**: 1990s  
**Creator**: Ralph Johnson et al.  
**Description**:  
Clients and services communicate via a broker that handles requests, discovery, and routing logic.

**When to use**: When dynamic discovery and heterogeneity are needed.  
**When not to use**: When simpler direct communication suffices.

**Use cases**: CORBA, Java RMI, legacy middleware.  
**Pros**: Decoupling, centralized discovery logic.  
**Cons**: Bottlenecks, added latency and complexity.

**Combine with**: SOA, EDA, Microservices.

**Evaluation**:  
- Facilidad: ★★☆☆☆
- Escalabilidad: ★★★☆☆
- Rendimiento: ★★☆☆☆
- Adaptabilidad: ★★★☆☆
- Resiliencia: ★★☆☆☆
- Coste: ★★☆☆☆

---

### [C/8] [Ambassador Pattern](./ambassador.md)
**Year**: 2015+  
**Description**:  
A proxy deployed alongside each service that handles cross-cutting concerns like retries, TLS, or logging.

**When to use**: For observability, mTLS, or retry logic in services.  
**When not to use**: When latency or simplicity is critical.

**Use cases**: Service-to-service observability, secure mTLS connections.  
**Pros**: Reusable logic, better separation, increased resilience.  
**Cons**: More deployments, added latency, debugging overhead.

**Combine with**: Service Mesh, Sidecar, Circuit Breaker.

**Evaluation**:  
Facilidad: ★★☆☆☆
- Escalabilidad: ★★★☆☆
- Rendimiento: ★★★☆☆
- Adaptabilidad: ★★★☆☆
- Resiliencia: ★★★★☆
- Coste: ★★☆☆☆

---

## 📊 Comparison Table

| Architecture        | Ease    | Scalability | Performance | Adaptability | Resilience | Cost     |
|---------------------|---------|-------------|-------------|--------------|------------|----------|
| Monolith (Layered)  | ★★★★☆  | ★★☆☆☆      | ★★★★☆      | ★★☆☆☆       | ★★☆☆☆     | ★★★★★   |
| Modular Monolith    | ★★★★☆  | ★★☆☆☆      | ★★★★☆      | ★★★☆☆       | ★★☆☆☆     | ★★★★☆   |
| MVC                 | ★★★★☆  | ★★☆☆☆      | ★★★☆☆      | ★★★★☆       | ★★☆☆☆     | ★★★★☆   |
| BFF                 | ★★★☆☆  | ★★★★☆      | ★★★★☆      | ★★★★☆       | ★★★☆☆     | ★★★☆☆   |
| SOA                 | ★★☆☆☆  | ★★★☆☆      | ★★☆☆☆      | ★★★☆☆       | ★★★☆☆     | ★★★☆☆   |
| Microservices       | ★★☆☆☆  | ★★★★★      | ★★★☆☆      | ★★★★★       | ★★★★☆     | ★★★★☆   |
| Broker              | ★★☆☆☆  | ★★★☆☆      | ★★☆☆☆      | ★★★☆☆       | ★★☆☆☆     | ★★☆☆☆   |
| Ambassador Pattern  | ★★☆☆☆  | ★★★☆☆      | ★★★☆☆      | ★★★☆☆       | ★★★★☆     | ★★☆☆☆   |

---

## ✅ License

MIT.  
Copyright © Juan G Carmona.  
Please attribute if you use or adapt this material.

---