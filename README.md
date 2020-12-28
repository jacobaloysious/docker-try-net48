# docker-try-net48
Try a docker dot net 4.8 console app inside a windows container

### How do you build: 
$docker build -t testapp .   

### How do you run:   
$docker run --rm -v <<localRepDir>>\jacapp\bin\Debug:c:\myapp\ testapp
