# tolowercaseprocessor.py file
# faster than 99.74%, memory usage less than 96.86%

class ToLowerCaseProcessor(object):
    def toLowerCase(self, str: 'str') -> 'str':
        result = map(lambda x:chr(ord(x)+32) if 90>=ord(x)>=65 else x,list(str))
        return "".join(result)