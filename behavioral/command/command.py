
# Command interface
class Command:
    def execute(self):
        pass

# Receiver class
class Receiver:
    def action(self):
        print("Receiver: Performing an action.")

# Concrete Command class
class ConcreteCommand(Command):
    def __init__(self, receiver):
        self.receiver = receiver

    def execute(self):
        self.receiver.action()

# Invoker class
class Invoker:
    def __init__(self):
        self._command = None

    def set_command(self, command):
        self._command = command

    def execute_command(self):
        if self._command:
            self._command.execute()

if __name__ == "__main__":
    receiver = Receiver()
    command = ConcreteCommand(receiver)

    invoker = Invoker()
    invoker.set_command(command)
    invoker.execute_command()
