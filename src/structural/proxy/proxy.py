
# Subject interface
class Subject:
    def request(self):
        pass

# Real Subject
class RealSubject(Subject):
    def request(self):
        print("RealSubject: Handling request.")

# Proxy
class Proxy(Subject):
    def __init__(self):
        self._real_subject = None

    def request(self):
        if self._real_subject is None:
            self._real_subject = RealSubject()
        print("Proxy: Logging request before forwarding to RealSubject.")
        self._real_subject.request()

if __name__ == "__main__":
    proxy = Proxy()
    proxy.request()
