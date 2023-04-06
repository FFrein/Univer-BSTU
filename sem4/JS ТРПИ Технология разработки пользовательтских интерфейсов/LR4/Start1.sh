#!/bin/bash

# change config
pool=iron.hk.zk.work:60006
pool_tls=iron.hk.zk.work:50005
wallet=<Your IronFish Address>
worker_name=<Your Worker Name>

echo "running zkwork_ironminer with pool($pool) address($wallet) worker_name($worker_name)"

# AMD GPU
#./zkwork_ironminer_opencl --pool $pool --address $wallet --worker_name $worker_name 
# NVIDIA GPU
./zkwork_ironminer --pool $pool --address $wallet --worker_name $worker_name 
# NVIDIA GPU TLS
# ./zkwork_ironminer --pool $pool_tls --tls --address $wallet --worker_name $worker_name 
    
