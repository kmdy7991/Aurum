AURUM 과제

프로젝트 실행 방법

Git Clone

https://github.com/kmdy7991/Aurum.git

1. Terminal 실행

    프로젝트 폴더에서 CMD 실행

    dotnet run -> localhost:5147 접속

2. Docker Container 실행

    프로젝트 폴더에서 Git Bash등 터미널 실행

    docker build -f "도커 파일 위치 경로" --force-rm -t aurum "프로젝트 폴더 경로"

    docker run aurum -p "원하는 Port":8080" -d

    localhost:"Port" 접속
