setup:
	mkdir -p ./test
up:
	docker stack deploy -c docker-compose.yml farming
down:
	docker stack rm farming 
check:
	docker service ls
network:
	docker network create --driver overlay mynetwork
networkprune:
	docker network prune	
test:
	docker images