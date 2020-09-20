#!/bin/bash
docker rm -f servicea
docker rmi service-a
docker build -t service-a .
docker run --name servicea -p 5001:80 -d service-a