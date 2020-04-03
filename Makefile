run:
	docker-compose up -d &&\
	dotnet restore &&\
	dotnet run --project ./apps/ReporterCli