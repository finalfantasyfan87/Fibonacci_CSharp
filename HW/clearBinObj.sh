#!/usr/bin/env bash
#script removes bin and obj directories after compiling and running code
find . -iname "bin" -o -iname "obj" | xargs rm -rf
