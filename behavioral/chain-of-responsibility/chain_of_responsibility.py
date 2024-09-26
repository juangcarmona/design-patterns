class Handler:
    def __init__(self):
        self._next_handler = None

    def set_next(self, handler):
        self._next_handler = handler

    def handle_request(self, request):
        raise NotImplementedError("This method should be overridden by subclasses")


class ConcreteHandler1(Handler):
    def handle_request(self, request):
        if request == "Request1":
            print("ConcreteHandler1 handled the request.")
        elif self._next_handler is not None:
            self._next_handler.handle_request(request)


class ConcreteHandler2(Handler):
    def handle_request(self, request):
        if request == "Request2":
            print("ConcreteHandler2 handled the request.")
        elif self._next_handler is not None:
            self._next_handler.handle_request(request)


if __name__ == "__main__":
    handler1 = ConcreteHandler1()
    handler2 = ConcreteHandler2()

    handler1.set_next(handler2)

    handler1.handle_request("Request1")
    handler1.handle_request("Request2")
    handler1.handle_request("UnknownRequest")
