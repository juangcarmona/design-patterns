### [F] Operational Infrastructure

This section includes patterns that operate at the technical infrastructure or operational behavior level. They are cross-cutting concerns that provide control, resilience, isolation, or extensibility. While not complete architectures, their correct application can make the difference between a stable platform and one that collapses under failure or load spikes.

---

### [F/1] Circuit Breaker

- **Year**: ~2012  
- **Creator**: Netflix (Hystrix) / Resilience4j  
- **Description**:  
  Interrupts calls to services that are repeatedly failing. After a defined number of consecutive errors, the circuit “opens” and immediately returns errors, protecting the system from overload. It later performs controlled tests to see if the service has recovered.

- **When to use / not use**:
  - ✅ Use it to prevent cascading failures.
  - ❌ Not needed if all services are reliable or in a monolith.

- **Use Cases**: Payments, critical microservices  
- **Pros**: Immediate resilience, resource protection  
- **Cons**: Requires fine-tuning, may degrade UX

- **Combine with**: Bulkhead, Retry, Service Mesh  
**Ratings**:  
Ease: ★★★☆☆ • Scalability: ★★★☆☆ • Performance: ★★★★☆ • Adaptability: ★★★☆☆ • Resilience: ★★★★★ • Cost: ★★★★☆

---

### [F/2] Bulkhead Pattern

- **Year**: ~2015  
- **Inspired by**: Naval compartmentalization  
- **Description**:  
  Divides system resources into isolated compartments. If one part becomes overloaded, others continue to operate normally. Improves resilience by limiting failure scope.

- **When to use / not use**:
  - ✅ Useful if some modules might overload without breaking everything.
  - ❌ Not for simple or centralized systems.

- **Use Cases**: Queues, critical functions  
- **Pros**: Fault containment  
- **Cons**: Risk of underutilization, added complexity

- **Combine with**: Circuit Breaker, Sidecar, Ambassador  
**Ratings**:  
Ease: ★★☆☆☆ • Scalability: ★★★★☆ • Performance: ★★★★☆ • Adaptability: ★★★☆☆ • Resilience: ★★★★★ • Cost: ★★★☆☆

---

### [F/3] Sidecar Pattern

- **Year**: 2015+  
- **Creator**: Kubernetes ecosystem  
- **Description**:  
  Auxiliary component deployed alongside the main service (e.g., in a pod). Adds technical features like logging, metrics, or proxies without touching application code.

- **When to use / not use**:
  - ✅ Great for telemetry, external configuration.
  - ❌ Avoid if it introduces unnecessary complexity.

- **Use Cases**: Istio, proxies, certificate management  
- **Pros**: Clear separation, reusability  
- **Cons**: Requires coordination, more troubleshooting

- **Combine with**: Ambassador, Circuit Breaker, Bulkhead  
**Ratings**:  
Ease: ★★☆☆☆ • Scalability: ★★★★☆ • Performance: ★★★☆☆ • Adaptability: ★★★☆☆ • Resilience: ★★★★☆ • Cost: ★★☆☆☆

---

## [F/4] Ambassador Pattern

**Year:** 2015+ (modern patterns in microservices)
**Creator:** Adapted from sidecar patterns, formalized in modern microservices

**Description**
An intermediate component that acts as a proxy between a service and the outside world. It handles common tasks such as authentication, retries, logging, or TLS without affecting the service core. It allows decoupling communication logic and improves observability in distributed environments.

**When to use/not to use**
– Use it when there is cross-cutting logic in the communication (retries, mTLS).
– Avoid if you don't need intermediaries or the overhead is excessive.

**Real-world use cases:** Microservices that require intelligent balancing or centralized metrics.
**Pros:** Simplifies repetitive logic, service isolation, and facilitates observability.
**Cons:** Adds latency, additional deployments, and more complex debugging.

**Combines with:** Sidecar, Circuit Breaker, Service Mesh.
**Ease of Use:** ★★☆☆☆ • **Scalability** ★★★☆☆ • **Performance** ★★★☆☆ • **Adaptable** ★★★☆☆ • **Resilient** ★★★★☆ • **Cost** ★★☆☆☆

---

## [F/5] Proxy (Design Pattern)

**Year:** 1994 (GoF)
**Creator:** Gamma, Helm, Johnson, Vlissides (GoF)

**Description**
A classic design pattern that encapsulates another object to control its access. It's used to apply additional logic such as validation, caching, concurrency control, or lazy loading, without modifying the original object. It's useful in both technical layers and domain models.

**When to use / when not to use**
Use it to add cross-cutting logic without modifying the actual object. Not necessary if there are no additional concerns.

**Use cases:** caching, validation, remote objects, security.
**Pros:** Centralizes control, improves modularity, easy extension.
**Cons:** Adds complexity and additional call layers.

**Combinable with:** Facade, Microservices, EDA.
**Ease:** ★★★★☆ • **Scalability:** ★★★☆☆ • **Performance:** ★★★☆☆ • **Adaptability:** ★★★★☆ • **Resilience:** ★★★☆☆ • **Cost:** ★★★★☆

> **NOTE:** Although both patterns (Proxy and Facade) were defined by the GoF, their objectives are different: one controls access, the other simplifies the interface.


---

## [F/6] Facade (Design Pattern)

**Year:** 1994 (GoF)
**Creator:** Gamma, Helm, Johnson, Vlissides (GoF)

**Description**
It offers a simplified interface that encapsulates the complexity of multiple subsystems or APIs. It reduces coupling and improves usability from the consumer's perspective. It's ideal when you need to expose functionality in a consistent and controlled manner.

**When to use / when not to use**
Use it to simplify access to complex APIs. Avoid it if there's no complexity to abstract away.

**Use cases:** libraries, frameworks, complex internal modules.
**Pros:** Reduces coupling, improves clarity, facilitates testing.
**Cons:** Can become a god object if abused.

**Combinable with:** Microservices, Hexagonal, Broker. **Ease of Use:** ★★★★☆ • **Scalability:** ★★☆☆☆ • **Performance:** ★★★★☆ • **Adaptability:** ★★★★☆ • **Resilience:** ★★★☆☆ • **Cost:** ★★★★★


---

## [F/7] Service Mesh

**Year:** 2017+ (popularized with Istio, Linkerd)
**Creator:** Google, Buoyant, Lyft (Envoy)

**Description**
Dedicated infrastructure that manages communication between services in distributed environments without touching your code. Use sidecar proxies to intercept traffic and apply policies such as mTLS, retries, traceability, or load balancing. This is key in cloud-native architectures that require observability and fine-grained control.

**When to use / when not to use**
– Use it when working with distributed microservices and need fine-grained traffic control or visibility between services.
– Avoid it if your system is simple or you cannot handle the operational complexity.

**Use cases:** Kubernetes environments, traffic management between microservices, canary deployments, security with mTLS, and distributed observability with tracing and metrics.

**Pros:** Strengthened security, traffic control, full traceability, separation of concerns.
**Cons:** Resource overhead, operational complexity, steep learning curve.

**Combinable with:** Sidecar, Ambassador, Circuit Breaker, BFF, Microservices.
**Ease:** ★★☆☆☆ • **Scalability:** ★★★★☆ • **Performance:** ★★★☆☆ • **Adaptability:** ★★★★☆ • **Resilience:** ★★★★★ • **Cost:** ★★☆☆☆

---

## Comparison Table

| Architecture | Ease | Scale | Performance | Adaptable | Resil. | Infrastructure |
|---------------------|-----------|--------|----------|--------|------------------|
| Circuit Breaker | ★★★☆☆ | ★★★☆☆ | ★★★★☆ | ★★★☆☆ | ★★★★★ | ★★★★☆ |
| Bulkhead Pattern | ★★☆☆☆ | ★★★★☆ | ★★★★☆ | ★★★☆☆ | ★★★★★ | ★★★☆☆ |
| Sidecar Pattern | ★★☆☆☆ | ★★★★☆ | ★★★☆☆ | ★★★☆☆ | ★★★★☆ | ★★☆☆☆ |
| Ambassador Pattern | ★★☆☆☆ | ★★★☆☆ | ★★★☆☆ | ★★★☆☆ | ★★★★☆ | ★★☆☆☆ |
| Proxy