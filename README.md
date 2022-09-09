# Container Optimization Using K-Means
## The Aim of the Project 
A waste collection system consisting of irregular container locations is not realistic and efficient. Vehicles need to collect containers systematically to prevent waste of time and money. Implementing optimization techniques is required to achieve it. The system is improved by using the K-Means clustering technique. 
## K-Means Clustering 
k-means clustering is one of the most common clustering techniques. In k-means clustering, the algorithm attempts to group observations into k groups, with each group having roughly equal variance. The number of groups, k, is specified by the user as a hyperparameter. Specifically, in k-means:
  1. k cluster “center” points are created at random locations. <br>
  2. For each observation: <br>
    a. The distance between each observation and the k center points is calculated. <br>
    b. The observation is assigned to the cluster of the nearest center point. <br>
  3. The center points are moved to the means (i.e., centers) of their respective clusters. <br>
  4. Steps 2 and 3 are repeated until no observation changes in cluster membership. <br>
At this point the algorithm is considered converged and stops. <br> <br>
It is important to note three things about k-means:
- K-means clustering assumes the clusters are convex shaped (e.g., a circle, a sphere). <br>
- All features are equally scaled. <br>
- The groups are balanced (i.e., have roughly the same number of observations). <br>

## Visual Explanation of the Logic Behind K-Means Algorithm 

In pseudo-code, k-means is: <br> 

```
initialize clustering 
loop until done
  compute mean of each cluster
  update clustering based on new means
end loop
```

- Figure 1 shows how the data were initially clustered. Each data point is visually colored red, yellow, or green to denote membership in a cluster. <br> <br>
<p align="center">
  <img src="https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-4-berkdemirciogluu/blob/master/images/initialclustering.jpg"/>
</p>
<p align="center"> Figure 1. Initial Random Clustering </p>

- The three colored circles in Figure 2 represent the means of each of the three clusters, which have been computed.
<p align="center">
  <img src="https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-4-berkdemirciogluu/blob/master/images/initialclustermeans.jpg"/>
</p>
<p align="center"> Figure 2. Initial Cluster Means </p>

- Each data tuple in Figure 3 is analyzed and positioned in the cluster that is closest to its corresponding mean.
<p align="center">
  <img src="https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-4-berkdemirciogluu/blob/master/images/clusteringupdated.jpg"/>
</p>
<p align="center"> Figure 3. Clustering Updated </p>

- In Figure 4, the new cluster means have been computed.
<p align="center">
  <img src="https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-4-berkdemirciogluu/blob/master/images/newmeanscalculated.jpg"/>
</p>
<p align="center"> Figure 4. New Means Computed </p>

- The clustering has been modified in Figure 5. The clustering has stabilized, as you can see. The best solution is not ensured by the k-means method. The algorithm often reaches a solution quite rapidly, though.
<p align="center">
  <img src="https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-4-berkdemirciogluu/blob/master/images/finalclusteringupdated.jpg"/>
</p>
<p align="center"> Figure 5. Final Clustering Update </p>





