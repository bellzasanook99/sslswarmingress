setup:
	mkdir -p ./test
up:
	docker stack deploy -c docker-compose.yml farming
down:
	docker stack rm farming 
check:
	docker service ls
