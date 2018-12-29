#!/usr/bin/env bash

# Normally the secret files would not be checked into source control
# I added them to make this sample instantly-runnable
docker secret create mysecrets__codeword ./secrets/codeword.txt
docker secret create mysecrets__nestedsecrets__othercode ./secrets/othercode.txt