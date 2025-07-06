
# [C/1] Monolith (N-Tier / Layered)

**Year**: 1995 (Three-Tier popularized)  
**Creator**: John J. Donovan  

## Description
Structured in layers (presentation, business logic, data access), all deployed as a single unit. This pattern is ideal for small applications or systems where complexity is limited. It is modified and tested as a whole block, which simplifies development in the early stages.

## When to Use / Avoid

- ✅ **Use** when the domain is simple and teams are small.
- ❌ **Avoid** in scenarios with rapid growth, multiple domains, or the need for scalable, independently deployable parts.

## Use Cases

- MVPs (Minimum Viable Products)
- Internal business tools
- Low-growth or legacy systems

## Pros

- Easy to implement
- Fewer infrastructure requirements
- Easy to test and deploy
- Low initial infrastructure cost

## Cons

- Poor scalability at a granular level
- Risk of becoming a "big ball of mud"
- Difficult to isolate and evolve specific areas

## Combinable With

- Modular Monolith
- Hexagonal Architecture
- Event-Driven Architecture (EDA) for triggering asynchronous tasks

## Evaluation

| Criteria           | Rating     |
|--------------------|------------|
| Implementation Ease | ★★★★☆ |
| Scalability         | ★★☆☆☆ |
| Performance         | ★★★★☆ |
| Adaptability        | ★★☆☆☆ |
| Resilience          | ★★☆☆☆ |
| Cost                | ★★★★★ |

---

## Diagram: Monolithic Architecture

```plaintext
+-------------------+
|   Presentation    |
|      Layer        |
+-------------------+
|  Business Logic   |
|      Layer        |
+-------------------+
|   Data Access     |
|      Layer        |
+-------------------+
|     Database      |
+-------------------+
```

All layers are packaged and deployed as a single unit.

---

## Example

A typical PHP or Ruby on Rails application with controllers, models, and views structured into folders and deployed as a single application (e.g., on Heroku or a VPS).

A legacy enterprise Java EE app using JSF + EJBs + JPA as layers.

