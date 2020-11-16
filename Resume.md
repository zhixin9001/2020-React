## 联系方式
- 手机：18165152056
- Email：zhixin9001@126.com

---

## 个人信息
- 智鑫/男/1991
- 硕士/陕西科技大学
- 工作年限：2015.12至今
- 技术博客：https://www.cnblogs.com/zhixin9001/
- Github：https://github.com/zhixin9001
- 当前职位：.NET开发
- 工作城市：西安

#### 技能
- 对工作认真负责，具备良好的团队协作能力，尽量增加代码的可读性、可维护性，喜欢在工作中承担一些有挑战的任务。
- 乐于分享，工作之余努力跟进主流技术，并在技术博客输出学习心得。
- 熟悉C#、ASP.NET Core、SQL Server、Docker等技术，熟悉Git、TFS，简单使用过Solr、HBase
- 熟悉Angular、TypeScript、BootStrap等前端技术，对React/Redux有粗略的了解。
- 了解微服务、DDD，学习过Consul、Ocelot、IdentityServer4等工具的使用。
- 对Redis、设计模式、算法、DevOps有基本的了解。
- 熟悉Scrum，参加过公司的Scrum培训，并在平时项目过程中实践。
- 具备一定的英文能力，通过了CET-6；通过了信息系统项目管理师考试。

---
## 工作经历
### 新蛋信息技术有限公司 （2017年8月 - 至今）
*所在部门：Sales Order组，该项目组负责订单相关功能的开发、维护工作*
#### Return Shipping Label重构
Return Shipping Label系统在新蛋的电商业务中，用于为客户生成退换货标签。本次重构由我们组一位资深开发设计，由我一人负责具体实现。
系统按照DDD模式进行重构，项目过程中了解、实践了DDD的基本思想，对关键模块和方法进行了单元测试。
项目完成后，在公司举办的季度优秀项目评比中，我负责该项目的文档编写、答辩工作，并获得了第一名。

#### Newegg Central 3.0
公司的上一代平台化的管理系统使用Sliverlight技术构建，在微软停止对Sliverlight技术的维护后，公司转而基于Angular开发Newegg Central 3.0。
在本项目中，我参与了将Sales Order相关页面向Newegg Central 3.0的迁移工作；并承担了若干探索性工作，且做了组内分享，比如：
- 在项目前期，尝试基于Angular构建页面、熟悉TypeScript语法，踩坑并寻找解决方案
- 使用Angular的AOT编译技术（Ahead Of Time）优化页面性能
- 为了能将公共组件提供给别的Team使用，将Anguler组件制作成npm包

#### Rest API重构
公司在将Web页面转向使用Angular的同时，也在进行将基于 .net framework开发的REST API重构为 .net core Web API的工作。
在本项目中，我完成了众多api的迁移，熟悉了asp .net core、docker、solr/hbase、DevOps等知识。

#### Swagger文档代理
这个项目为了解决生产环境API的Swagger文档无法显示的问题。项目组使用 .net core开发的API部署在Docker容器，而且在生产环境会依赖公司的Gateway、OAuth等基础设施，这就导致API的Swagger由于存在OAuth而无法访问。
项目由我独立实现，用python flask开发api，负责将服务注册到consul，并转发对swagger文档的请求，以绕过OAuth。

---
### 北京彼速信息技术有限公司（2015.12 - 2017.7）

```公司面向企业、代理机构客户和政府部门，提供知识产权管理与应用软件解决方案```
#### 代理机构工作平台(IPS+)  
软件客户为专利代理机构，以工作流为基础，提供客户、案件、任务链的管理和绩效的评估，使代理机构中部门经理、代理人、流程人员等能够协同工作。
我在项目中负责新需求的实现、现有功能模块的维护等。 


#### 广州代办处专利分析系统
用于广州代办处从各个维度统计广东省的专利申请、授权情况。涉及到Excel原始数据的导入、导入数据的地址清洗、对大量数据的多维度查询统计、用图表和表格的形式展示统计结果、生成Word格式的统计简报、统计结果的导出打印等
我在项目中负责页面功能的实现、用OpenXML生成Word简报等，并参与了数据库查询、写入速度的优化。

#### 地址清洗工具
与广州代办处专利分析系统配套使用，用于处理EXCEL形式的专利数据，将人工输入的地址转换成格式规范的地址。
该工具由我独立设计、开发、维护，期间经过若干次重构。

---
### 咸阳非金属研究院（2014.09 - 2015.11）
```研究生实习工作，在导师的指导下，为咸阳非金属研究院开发XYS-75摩擦试验仪的配套PC程序```
### XYS-75桌面程序
XYS-75摩擦试验仪的配套桌面程序，该程序负责与西门子PLC控制器通讯，以控制设备的工作，同时记录传感器采集的温度、压力、转速等数据，并实时显示。
项目涉及的技术有：Socket通讯、GDI+绘图、Access数据库、COM方式操作Office等

---
### 其他
#### 新蛋2020年编程马拉松
参加了公司举办的2020年编程马拉松活动，作品为一款基于Jira数据的甘特图Chrome插件。我在小组内的职责为页面交互、项目封装。在这个过程中，初步学习了React和Redux的使用。
编程马拉松刚刚结束不久，目前正在系统学习React中。

#### OCR Tool
*GitHub:https://github.com/zhixin9001/OCR_Tool*

一款文字识别小工具，基于百度云的OCR接口，使用WinForm开发。
家人在平时查找文献时经常会用到。

#### 极简记账
*GitHub:https://github.com/zhixin9001/2019-learn_android/tree/master/Tally*

一个用于随手记账的App，辅助培养理财技能，使用原生安卓开发，支持收支记录、支出比例分析、历史比较、导出导入csv数据。
日常重度使用。

---
## 技术文章
- [翻译-如何更好地编写单元测试（上）](https://www.cnblogs.com/zhixin9001/p/6730440.html)
- [设计模式(1) 工厂方法模式](https://www.cnblogs.com/zhixin9001/p/13227547.html)
- [《算法》笔记 1 - 栈和队列](https://www.cnblogs.com/zhixin9001/p/11324858.html)

- [《程序员修炼之道》笔记（一）](https://www.cnblogs.com/zhixin9001/p/6764767.html)
- [代码操作Word时，目录自动更新的两种方法](https://www.cnblogs.com/zhixin9001/p/5587322.html)

