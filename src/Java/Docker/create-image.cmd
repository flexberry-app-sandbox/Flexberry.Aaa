docker build --no-cache -f SQL\Dockerfile.PostgreSql -t aaa-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t aaa-java/app ../../..
