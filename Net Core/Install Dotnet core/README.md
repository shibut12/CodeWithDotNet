#   Install Dotnet core in Linux Mac and Windows

##Linux
1.  Enter following commands in bash shell
sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list'
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893
sudo apt-get update

2.  Install Dotnet core
sudo apt-get install dotnet-dev-1.0.1

3.  Check .Net core framework version to verify installation
dotnet --version

If the isntallation is successful, you will see following message on screen

shibu@myVM:~/dotnet$ dotnet --version
1.0.1


