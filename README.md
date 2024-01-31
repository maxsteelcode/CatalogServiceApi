
##About the project:

CatalogServiceApi is a project in .Net 5 that makes a CRUD in MongoDb.
It uses MongoCollection implementation.

---

###How to use

1. Clone the project to your machine

2. After that, run the docker-compose to build and run the containers. (You will need docker in your machine)

In the root folder of the solution, run this command in terminal/powershell: 

docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

3. After the container is running, you will be able to access the following url:

http://localhost:8081/swagger/index.html

---

There is a Seed method to insert 3 products, so you can start testing the Api by getting all products.
