using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestService
{
    // Consul配置模型类
    public class ConsulServiceOptions
    {
        // 服务注册地址（Consul的地址，如果是集群，取任意一个地址即可）
        public string ConsulAddress { get; set; }

        // 服务ID
        public string ServiceId { get; set; }

        // 服务名称
        public string ServiceName { get; set; }

        // 健康检查地址
        public string HealthCheck { get; set; }

        /// <summary>
        /// 当前服务IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 当前服务端口
        /// </summary>
        public string Port { get; set; }
    }
}
