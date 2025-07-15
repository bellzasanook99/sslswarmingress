docker stack deploy -c docker-compose.yml farming

docker stack rm farming

docker network create   --driver overlay   --attachable   traefik-publicnew

docker build -t movetarnet:1.0 .