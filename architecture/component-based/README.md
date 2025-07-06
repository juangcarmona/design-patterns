# 🧱 Component-Based Architectural Styles

Component-based architectures emphasize **modularity** and **separation of concerns**. The system is broken into well-defined components with clear responsibilities and communication mechanisms. This approach supports long-term evolution, extensibility (even by third parties), and internal organization.

---

### [D/1] [Microkernel (Plug‑in / Plugin)](./microkernel.md)  
**Year**: 1981 (OS); 1990s (apps)  
**Creator**: Concept from OS kernels (e.g., Mach), popularized in extensible apps like Eclipse RCP  
**Description**:  
A minimal core provides essential services (e.g., plugin loading, logging). Functionality is extended via loosely coupled modules. Supports modular evolution without breaking the core.

**When to use / avoid**:  
– Use in extensible apps like IDEs or CMS.  
– Avoid if you don’t need plugin extensibility.

**Use Cases**: Eclipse, Jenkins, plugin-based platforms.  
**Pros**: functional scalability, 3rd-party extensibility.  
**Cons**: plugin versioning issues, architectural complexity.  
**Combinable with**: hexagonal, modular monolith.  
**Evaluation**:  
Implementation Ease: ★★☆☆☆  
Scalability: ★★★☆☆  
Performance: ★★☆☆☆  
Adaptability: ★★★★★  
Resilience: ★★★☆☆  
Cost: ★★★☆☆

---

### [D/2] [Hexagonal (Ports & Adapters)](./hexagonal.md)  
**Year**: 2005  
**Creator**: Alistair Cockburn  
**Description**:  
Separates business logic from external dependencies. Uses ports to define interactions and adapters to implement them, enabling easier testing and tech replacement.

**When to use / avoid**:  
– Use for framework-agnostic logic.  
– Avoid if your app is trivial or CRUD-only.

**Use Cases**: maintainable apps, heavy unit testing.  
**Pros**: high testability, tech-agnostic design.  
**Cons**: mild over-engineering if simple domain.  
**Combinable with**: modular monolith, microservices, CQRS.  
**Evaluation**:  
Implementation Ease: ★★★★☆  
Scalability: ★★☆☆☆  
Performance: ★★★★☆  
Adaptability: ★★★★★  
Resilience: ★★★☆☆  
Cost: ★★★★☆

---

### [D/3] [Entity–Control–Boundary (ECB)](./ecb.md)  
**Year**: 1992  
**Creator**: Ivar Jacobson (OOSE)  
**Description**:  
Three roles:  
– Entity: domain logic and persistence  
– Control: orchestrates use cases  
– Boundary: handles UI and external interfaces

**When to use / avoid**:  
– Use in well-defined use-case-driven systems.  
– Avoid for simple CRUD.

**Use Cases**: enterprise systems, inventory management.  
**Pros**: clean responsibilities, testable units.  
**Cons**: unnecessary in simple apps.  
**Combinable with**: Clean Arch, Hexagonal, CQRS.  
**Evaluation**:  
Implementation Ease: ★★★★☆  
Scalability: ★★☆☆☆  
Performance: ★★★☆☆  
Adaptability: ★★★★☆  
Resilience: ★★☆☆☆  
Cost: ★★★★☆

---

### [D/4] [Anti‑Corruption Layer](./acl.md)  
**Year**: ~2015  
**Creator**: Martin Fowler / Eric Evans (DDD)  
**Description**:  
An intermediate layer that shields your domain model from external models. Translates data, logic, and semantics to prevent contamination from legacy or third-party systems.

**When to use / avoid**:  
– Use when integrating unstable/legacy systems.  
– Avoid when you control both ends.

**Use Cases**: legacy integration, vendor APIs.  
**Pros**: semantic isolation, model protection.  
**Cons**: extra maintenance and possible duplication.  
**Combinable with**: Strangler, SOA, EDA.  
**Evaluation**:  
Implementation Ease: ★★★★☆  
Scalability: ★★☆☆☆  
Performance: ★★★★☆  
Adaptability: ★★★★☆  
Resilience: ★★★☆☆  
Cost: ★★★☆☆

---

### [D/5] [Strangler Fig Pattern](./strangler.md)  
**Year**: ~2016  
**Creator**: Martin Fowler  
**Description**:  
Facilitates gradual migration by intercepting requests and routing them to newer modules. Coexists with the legacy system until it's fully replaced.

**When to use / avoid**:  
– Use to modernize without a full rewrite.  
– Avoid if full replacement is quick and safe.

**Use Cases**: modernizing monoliths, step-by-step rewrites.  
**Pros**: low risk, incremental delivery.  
**Cons**: complexity in routing and hybrid coexistence.  
**Combinable with**: BFF, API Gateway, Ambassador pattern.  
**Evaluation**:  
Implementation Ease: ★★☆☆☆  
Scalability: ★★★★☆  
Performance: ★★★☆☆  
Adaptability: ★★★★☆  
Resilience: ★★★☆☆  
Cost: ★★★☆☆

---

### 🧮 Comparison Table

| Architecture             | Ease     | Scalability | Performance | Adaptability | Resilience | Cost     |
|--------------------------|----------|-------------|-------------|--------------|------------|----------|
| Microkernel              | ★★☆☆☆    | ★★★☆☆       | ★★☆☆☆       | ★★★★★        | ★★★☆☆      | ★★★☆☆    |
| Hexagonal (Ports & Adapters) | ★★★★☆ | ★★☆☆☆       | ★★★★☆       | ★★★★★        | ★★★☆☆      | ★★★★☆    |
| Entity–Control–Boundary  | ★★★★☆    | ★★☆☆☆       | ★★★☆☆       | ★★★★☆        | ★★☆☆☆      | ★★★★☆    |
| Anti‑Corruption Layer    | ★★★★☆    | ★★☆☆☆       | ★★★★☆       | ★★★★☆        | ★★★☆☆      | ★★★☆☆    |
| Strangler Fig Pattern    | ★★☆☆☆    | ★★★★☆       | ★★★☆☆       | ★★★★☆        | ★★★☆☆      | ★★★☆☆    |
