#!/usr/bin/env python
import os
file = os.path.abspath('graph2d_java_wrap.cpp')
text = open(file).read()
text = text.replace('jstring jname = 0 ;', 'jstring jname = 0; TmpJOBJ jtmp(jenv, &jname);')
text = text.replace('swig_disconnect_director_self("swigDirectorDisconnect");', \
                    '//swig_disconnect_director_self("swigDirectorDisconnect");')
open(file, 'w').write(text)
