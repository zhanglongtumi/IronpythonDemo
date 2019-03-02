# -*- coding: gb2312 -*-
import sys
import time
import clr
clr.AddReference('IronpythonDemo')
from IronpythonDemo import *

ctrl = ScriptFunLib()

ctrl.PrintLine("hello world")