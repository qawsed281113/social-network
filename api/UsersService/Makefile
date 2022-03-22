all: run
run-postgres:
	docker run --name social_users_db -p 5432:5432 -e POSTGRES_PASSWORD=social_2580 -d postgres
apply-migrations: run-postgres
	dotnet ef database update
run: run-postgres apply-migrations
	dotnet run
clean:
	docker stop social_users_db && docker rm social_users_db