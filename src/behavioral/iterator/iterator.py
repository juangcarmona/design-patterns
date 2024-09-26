
# Iterator interface
class Iterator:
    def has_next(self):
        pass

    def next(self):
        pass

# Concrete Iterator
class ConcreteIterator(Iterator):
    def __init__(self, collection):
        self._collection = collection
        self._position = 0

    def has_next(self):
        return self._position < len(self._collection)

    def next(self):
        if self.has_next():
            item = self._collection[self._position]
            self._position += 1
            return item
        return None

# Aggregate interface
class Aggregate:
    def create_iterator(self):
        pass

# Concrete Aggregate
class ConcreteAggregate(Aggregate):
    def __init__(self):
        self._collection = []

    def add_item(self, item):
        self._collection.append(item)

    def create_iterator(self):
        return ConcreteIterator(self._collection)

if __name__ == "__main__":
    aggregate = ConcreteAggregate()
    aggregate.add_item("Item 1")
    aggregate.add_item("Item 2")
    aggregate.add_item("Item 3")

    iterator = aggregate.create_iterator()
    while iterator.has_next():
        print(iterator.next())
