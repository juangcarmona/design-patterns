
# Subsystem A
class SubsystemA:
    def operation_a(self):
        print("SubsystemA: OperationA")

# Subsystem B
class SubsystemB:
    def operation_b(self):
        print("SubsystemB: OperationB")

# Facade class
class Facade:
    def __init__(self, subsystem_a, subsystem_b):
        self._subsystem_a = subsystem_a
        self._subsystem_b = subsystem_b

    def operation(self):
        print("Facade: Operation")
        self._subsystem_a.operation_a()
        self._subsystem_b.operation_b()

if __name__ == "__main__":
    subsystem_a = SubsystemA()
    subsystem_b = SubsystemB()
    facade = Facade(subsystem_a, subsystem_b)
    facade.operation()
