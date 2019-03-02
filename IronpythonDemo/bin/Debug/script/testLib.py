# -*- coding: gb2312 -*-
import sys
import time
import clr
clr.AddReference('IronpythonDemo')
from IronpythonDemo import *
clr.AddReference('TestScriptLib')
from TestScriptLib import *

ctrl = ScriptFunLib()

test_lib = TestClass()

ctrl.PrintLine("----")
ctrl.PrintLine(str(test_lib.add(3, 3)))
ctrl.PrintLine("----")

