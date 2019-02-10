import unittest
from ToLowerCaseProcessor import ToLowerCaseProcessor

class Test_ToLowerCase(unittest.TestCase):
    def test_ToLowerCase_A(self):
        lcp = ToLowerCaseProcessor()
        self.assertEqual("a", lcp.toLowerCase("A"))
        
    def test_ToLowerCase_Z(self):
        lcp = ToLowerCaseProcessor()
        self.assertEqual("z", lcp.toLowerCase("Z"))

    def test_ToLowerCase_Hello(self):
        lcp = ToLowerCaseProcessor()
        self.assertEqual("hello", lcp.toLowerCase("Hello"))

    def test_ToLowerCase_Alphabet(self):
        lcp = ToLowerCaseProcessor()
        self.assertEqual("al&phabet", lcp.toLowerCase("al&phaBET"))
        
if __name__ == '__main__':
    unittest.main()
