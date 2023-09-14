https://shreya0901@shreya-0901-app.scm.azurewebsites.net/shreya-0901-app.git
"principalId": "a41d8e34-478f-42b1-96df-20abff51ea88",
  "tenantId": "1f2570ff-92be-43ad-b956-31fa87a29d03",
  "type": "SystemAssigned",
  "userAssignedIdentities": null

git add .
git commit -m "Updated web app to access my key vault"
git push azure main

 "aadProfile": null,
  "addonProfiles": {
    "azureKeyvaultSecretsProvider": {
      "config": {
        "enableSecretRotation": "false",
        "rotationPollInterval": "2m"
      },
      "enabled": true,
      "identity": {
        "clientId": "492d53ee-9d42-4910-95b8-6d578f962585",
        "objectId": "7ab98519-4c9d-412d-8c81-a6811d695e06",
        "resourceId": "/subscriptions/e8e4c4b2-0830-494b-be62-9eb0ed62e9f2/resourcegroups/MC_shreya-azure_shreya-aks_eastus/providers/Microsoft.ManagedIdentity/userAssignedIdentities/azurekeyvaultsecretsprovider-shreya-aks"
      }
    },
    "azurepolicy": {
      "config": null,
      "enabled": true,
      "identity": {
        "clientId": "fe3f4c4d-e235-40c6-919b-60300c5b3630",
        "objectId": "05e2d21f-6635-4859-a287-32209bbdf9b9",
        "resourceId": "/subscriptions/e8e4c4b2-0830-494b-be62-9eb0ed62e9f2/resourcegroups/MC_shreya-azure_shreya-aks_eastus/providers/Microsoft.ManagedIdentity/userAssignedIdentities/azurepolicy-shreya-aks"
      }
    }
  },
  "agentPoolProfiles": [
    {
      "availabilityZones": null,
      "count": 1,
      "creationData": null,
      "currentOrchestratorVersion": "1.26.6",
      "enableAutoScaling": true,
      "enableEncryptionAtHost": null,
      "enableFips": false,
      "enableNodePublicIp": false,
      "enableUltraSsd": null,
      "gpuInstanceProfile": null,
      "hostGroupId": null,
      "kubeletConfig": null,
      "kubeletDiskType": "OS",
      "linuxOsConfig": null,
      "maxCount": 2,
      "maxPods": 110,
      "minCount": 1,
      "mode": "System",
      "name": "agentpool",
      "nodeImageVersion": "AKSUbuntu-2204gen2containerd-202308.22.0",
      "nodeLabels": {
        "shreya": "test"
      },
      "nodePublicIpPrefixId": null,
      "nodeTaints": null,
      "orchestratorVersion": "1.26.6",
      "osDiskSizeGb": 128,
      "osDiskType": "Managed",
      "osSku": "Ubuntu",
      "osType": "Linux",
      "podSubnetId": null,
      "powerState": {
        "code": "Running"
      },
      "provisioningState": "Succeeded",
      "proximityPlacementGroupId": null,
      "scaleDownMode": null,
      "scaleSetEvictionPolicy": null,
      "scaleSetPriority": null,
      "spotMaxPrice": null,
      "tags": {
        "shreya": "test"
      },
      "type": "VirtualMachineScaleSets",
      "upgradeSettings": null,
      "vmSize": "Standard_DS2_v2",
      "vnetSubnetId": null,
      "workloadRuntime": null
    }
  ],
  "apiServerAccessProfile": null,
  "autoScalerProfile": {
    "balanceSimilarNodeGroups": "false",
    "expander": "random",
    "maxEmptyBulkDelete": "10",
    "maxGracefulTerminationSec": "600",
    "maxNodeProvisionTime": "15m",
    "maxTotalUnreadyPercentage": "45",
    "newPodScaleUpDelay": "0s",
    "okTotalUnreadyCount": "3",
    "scaleDownDelayAfterAdd": "10m",
    "scaleDownDelayAfterDelete": "10s",
    "scaleDownDelayAfterFailure": "3m",
    "scaleDownUnneededTime": "10m",
    "scaleDownUnreadyTime": "20m",
    "scaleDownUtilizationThreshold": "0.5",
    "scanInterval": "10s",
    "skipNodesWithLocalStorage": "false",
    "skipNodesWithSystemPods": "true"
  },
  "autoUpgradeProfile": {
    "upgradeChannel": "patch"
  },
  "azurePortalFqdn": "shreya-aks-dns-nqchwiff.portal.hcp.eastus.azmk8s.io",
  "currentKubernetesVersion": "1.26.6",
  "disableLocalAccounts": false,
  "diskEncryptionSetId": null,
  "dnsPrefix": "shreya-aks-dns",
  "enablePodSecurityPolicy": null,
  "enableRbac": true,
  "extendedLocation": null,
  "fqdn": "shreya-aks-dns-nqchwiff.hcp.eastus.azmk8s.io",
  "fqdnSubdomain": null,
  "httpProxyConfig": null,
  "id": "/subscriptions/e8e4c4b2-0830-494b-be62-9eb0ed62e9f2/resourcegroups/shreya-azure/providers/Microsoft.ContainerService/managedClusters/shreya-aks",        
  "identity": {
    "principalId": "213a705b-05fd-40b0-a177-432ae172ecd7",
    "tenantId": "1f2570ff-92be-43ad-b956-31fa87a29d03",
    "type": "SystemAssigned",
    "userAssignedIdentities": null
  },
  "identityProfile": {
    "kubeletidentity": {
      "clientId": "93624ed1-3e9c-4bb8-90c1-58f075245ae5",
      "objectId": "900d353e-a349-4ed4-a3f3-958917e9a34f",
      "resourceId": "/subscriptions/e8e4c4b2-0830-494b-be62-9eb0ed62e9f2/resourcegroups/MC_shreya-azure_shreya-aks_eastus/providers/Microsoft.ManagedIdentity/userAssignedIdentities/shreya-aks-agentpool"
    }
  },
  "kubernetesVersion": "1.26.6",
  "linuxProfile": null,
  "location": "eastus",
  "maxAgentPools": 100,
  "name": "shreya-aks",
  "networkProfile": {
    "dnsServiceIp": "10.0.0.10",
    "dockerBridgeCidr": null,
    "ipFamilies": [
      "IPv4"
    ],
    "loadBalancerProfile": {
      "allocatedOutboundPorts": null,
      "effectiveOutboundIPs": [
        {
          "id": "/subscriptions/e8e4c4b2-0830-494b-be62-9eb0ed62e9f2/resourceGroups/MC_shreya-azure_shreya-aks_eastus/providers/Microsoft.Network/publicIPAddresses/8d9400ba-88a6-4193-932a-187fc6bfa45f",
          "resourceGroup": "MC_shreya-azure_shreya-aks_eastus"
        }
      ],
      "enableMultipleStandardLoadBalancers": null,
      "idleTimeoutInMinutes": null,
      "managedOutboundIPs": {
        "count": 1,
        "countIpv6": null
      },
      "outboundIPs": null,
      "outboundIpPrefixes": null
    },
    "loadBalancerSku": "Standard",
    "natGatewayProfile": null,
    "networkMode": null,
    "networkPlugin": "kubenet",
    "networkPolicy": null,
    "outboundType": "loadBalancer",
    "podCidr": "10.244.0.0/16",
    "podCidrs": [
      "10.244.0.0/16"
    ],
    "serviceCidr": "10.0.0.0/16",
    "serviceCidrs": [
      "10.0.0.0/16"
    ]
  },
  "nodeResourceGroup": "MC_shreya-azure_shreya-aks_eastus",
  "oidcIssuerProfile": {
    "enabled": false,
    "issuerUrl": null
  },
  "podIdentityProfile": null,
  "powerState": {
    "code": "Running"
  },
  "privateFqdn": null,
  "privateLinkResources": null,
  "provisioningState": "Succeeded",
  "publicNetworkAccess": null,
  "resourceGroup": "shreya-azure",
  "securityProfile": {
    "azureKeyVaultKms": null,
    "defender": null
  },
  "servicePrincipalProfile": {
    "clientId": "msi",
    "secret": null
  },
  "sku": {
    "name": "Basic",
    "tier": "Free"
  },
  "storageProfile": {
    "blobCsiDriver": null,
    "diskCsiDriver": {
      "enabled": true
    },
    "fileCsiDriver": {
      "enabled": true
    },
    "snapshotController": {
      "enabled": true
    }
  },
  "systemData": null,
  "tags": {
    "shreya": "test"
  },
  "type": "Microsoft.ContainerService/ManagedClusters",
  "windowsProfile": null,
  "workloadAutoScalerProfile": {
    "keda": null
  }
}
492d53ee-9d42-4910-95b8-6d578f962585 => resource id
