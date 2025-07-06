# [E] Distributed / Coordination

This group of patterns emerges when systems are distributed across multiple nodes, instances, or regions. They require coordination, consensus, or isolation mechanisms to prevent inconsistencies and systemic failures. These styles address distributed governance, resilience, progressive migration, or zero-downtime evolution and updates. They are typically more complex, but essential for scalable and fault-tolerant architectures.

---

## [E/1] [Peer-to-Peer (P2P)](./peer-to-peer.md)

**Year**: Popular since Napster (1999), refined in the 2000s  
**Creator**: Decentralized networking concepts  
**Description**:  
In a P2P network, each node acts simultaneously as a client and a server, with no need for a central control point. Logic and data are distributed among nodes, allowing horizontal scalability, decentralization, and fault tolerance.

**When to use / not use**:
- ✅ Use for decentralized, highly available, autonomously balanced systems.
- ❌ Avoid when centralized control, traceability, or strong consistency are essential.

**Examples**: Torrent, blockchain, decentralized chat.

**Pros**:
- Highly fault-tolerant, naturally scalable.

**Cons**:
- Hard to secure, hard to coordinate transactions.

**Often combined with**: Blockchain, event streaming, EDA

**Ratings**:
- Ease: ★★☆☆☆  
- Scalability: ★★★★★  
- Performance: ★★★☆☆  
- Adaptability: ★★★☆☆  
- Resilience: ★★★★★  
- Cost: ★★★★☆

---

## [E/2] [Leader Election](./leader-election.md)

**Year**: Classic in distributed systems  
**Creator**: Consensus algorithms like Raft, Paxos  
**Description**:  
Mechanism to ensure that in a distributed system, one node is designated as the leader at any given time. This node handles critical tasks like orchestration, synchronized writing, or access control. It’s based on algorithms like Raft or Paxos that guarantee consensus.

**When to use / not use**:
- ✅ Use when temporary centralized coordination is required (distributed locks, task planning, synchronized writes).
- ❌ Not needed if nodes are fully autonomous or eventual inconsistency is acceptable.

**Examples**: Distributed databases, cron coordination, Kafka Zookeeper.

**Pros**: Single point of control, avoids conflicts, ensures consistency.  
**Cons**: Leader failure may cause latency or split-brain if re-election isn’t handled well.

**Often combined with**: Sharding, Coordinator services, EDA

**Ratings**:
- Ease: ★★☆☆☆  
- Scalability: ★★★☆☆  
- Performance: ★★★★☆  
- Adaptability: ★★★☆☆  
- Resilience: ★★★☆☆  
- Cost: ★★★☆☆

---

## [E/3] [Micro Frontend](./micro-frontend.md)

**Year**: 2019+  
**Creator**: Formalized by ThoughtWorks; standard in JavaScript communities  
**Description**:  
Splits the UI into independent micro-apps, each developed, versioned, and deployed by separate teams. Each fragment may use its own tech stack and logic, being assembled at runtime into a unified Single Page Application (SPA). This allows frontend teams to scale like microservices do in the backend.

**When to use / not use**:
- ✅ Use in complex frontend platforms with multiple modules/domains/teams.
- ❌ Avoid in simple projects where it introduces more complexity than it solves.

**Examples**: Corporate portals, large SPAs, SaaS platforms with modular domains.

**Pros**: Team independence, autonomous deployment, tech flexibility.  
**Cons**: Coordination overhead, initial load, inconsistent UX if not managed carefully.

**Often combined with**: BFF, Microservices, Proxy

**Ratings**:
- Ease: ★★☆☆☆  
- Scalability: ★★★★★  
- Performance: ★★★☆☆  
- Adaptability: ★★★★★  
- Resilience: ★★★☆☆  
- Cost: ★★★☆☆

---

## 🔢 Comparative Table

| Architecture      | Ease  | Scale | Performance | Adaptability | Resilience | Cost  |
|-------------------|:-----:|:-----:|:-----------:|:------------:|:----------:|:-----:|
| Peer‑to‑Peer      | ★★☆☆☆ | ★★★★★ | ★★★☆☆       | ★★★☆☆        | ★★★★★      | ★★★★☆ |
| Leader Election   | ★★☆☆☆ | ★★★☆☆ | ★★★★☆       | ★★★☆☆        | ★★★☆☆      | ★★★☆☆ |
| Micro Frontend    | ★★☆☆☆ | ★★★★★ | ★★★☆☆       | ★★★★★        | ★★★☆☆      | ★★★☆☆ |
