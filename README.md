# FireRedAsr
FireRedAsr是一个用于解码FireRedASR AED-L模型的c#库，用于语音识别（ASR）

### 简介：
FireRedAsr 是一款基于 C# 开发的语音识别（ASR）库。该库兼容性优异，支持net461+、.NET6.0+等框架版本，不仅专注于高效完成语音识别任务，还具备出色的跨平台能力，支持在 Windows、Linux、Android、macOS、iOS 等多平台上进行编译与调用，适配场景广泛。
其核心依赖的 FireRedASR-AED 模型，以平衡高性能与计算效率为设计目标，采用基于注意力机制的编码器 - 解码器（AED）架构，能够作为基于大语言模型（LLM）的语音模型中的高效语音表示模块，为语音识别任务提供稳定且优质的技术支撑

### 支持的模型（ONNX）
| 模型名称  |  类型 | 时间戳 |  支持语言  | 下载地址  |
| ------------ | ------------ | ------------ | ------------ | ------------ |
|  fireredasr-aed-large-zh-en-onnx-offline-20250124 | 非流式 | 否  | 中文、英文  |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr-aed-large-zh-en-onnx-offline-20250124 "modelscope") |
|  fireredasr2-aed-large-zh-en-onnx-offline-20260212 | 非流式 | 是  | 中文、英文  |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr2-aed-large-zh-en-onnx-offline-20260212 "modelscope") |
|  fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212 | 非流式 | 是  | 中文、英文  |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212 "modelscope") |

### 如何使用
#### 1.克隆项目源码
```bash
cd /path/to
git clone https://github.com/manyeyes/FireRedASR.git
```
#### 2.下载上述列表中的模型到目录：/path/to/FireRedASR/FireRedASR.Examples
```bash
cd /path/to/FireRedASR/FireRedASR.Examples
git clone https://www.modelscope.cn/manyeyes/[模型名称].git
```
#### 3.使用vs2022(或其他IDE)加载工程，
#### 4.将模型目录中的文件设置为：复制到输出目录->如果较新则复制
#### 5.修改示例中代码：string modelName =[模型目录名]
#### 6.如何调用
参考:FireRedAsrExamples.cs中的示例代码
#### 7.如何运行示例程序
##### 1.下载模型到Application directory（参考窗口提示）：
```bash
git clone https://www.modelscope.cn/manyeyes/fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212.git
```
##### 2.运行示例
```bash
-type offline -files /path/to/0.wav
```
##### 3.运行结果
```
/path/to/0.wav
{"text": "对我做了介绍啊那么我想说的是呢大家如果对我的研究感兴趣呢嗯","word":["对","我","做","了","介","绍","啊","那","么","我","想","说","的","是","呢","大","家","如","果","对","我","的","研","究","感","兴","趣","呢","嗯"],"timestamps":[[440,480],[600,640],[720,760],[840,960],[1040,1120],[1320,1360],[1760,1840],[1880,1960],[2080,2160],[2200,2280],[2360,2400],[2480,2560],[2600,2680],[2760,2840],[3200,3280],[3320,3400],[3480,3560],[3600,3640],[3680,3760],[3800,3880],[3880,3920],[3960,4040],[4080,4160],[4240,4320],[4400,4520],[4600,4680],[4760,4840],[5080,5120],[5560,5600]]}

/path/to/1.wav
{"text": "重点呢想谈三个问题首先呢就是这一轮全球金融动荡的表现","word":["重","点","呢","想","谈","三","个","问","题","首","先","呢","就","是","这","一","轮","全","球","金","融","动","荡","的","表","现"],"timestamps":[[280,360],[400,480],[560,600],[720,800],[920,1000],[1040,1120],[1160,1280],[1320,1440],[2080,2200],[2280,2360],[2440,2480],[2560,2640],[2720,2800],[2960,3040],[3120,3200],[3240,3320],[3440,3520],[3600,3680],[3760,3800],[3880,3920],[4000,4080],[4160,4240],[4280,4360],[4440,4560],[4640,4720],[5120,5160]]}

/path/to/2.wav
{"text": "well i don't wish to see it any more observed phoebe turning away her eyes it is certainly very like the old portrait","word":["well","i","don't","wish","to","see","it","any","more","observed","phoebe","turning","away","her","eyes","it","is","certainly","very","like","the","old","portrait"],"timestamps":[[760,800],[840,920],[920,1120],[1120,1360],[1400,1480],[1560,1640],[1720,1800],[1920,2000],[2200,2240],[2240,2680],[2680,3440],[3480,3840],[3920,4000],[4080,4280],[5000,5080],[5160,5240],[5360,5600],[5640,5920],[6040,6160],[6280,6320],[6400,6480],[6600,6680],[6680,7000]]}

recognition_elapsed_milliseconds:3645.171875
total_duration_milliseconds:18199.5625
rtf:0.2002889835950727
```
###### 相关工程：
* 语音端点检测，解决长音频合理切分的问题，项目地址：[AliFsmnVad](https://github.com/manyeyes/AliFsmnVad "AliFsmnVad") 
* 文本标点预测，解决识别结果没有标点的问题，项目地址：[AliCTTransformerPunc](https://github.com/manyeyes/AliCTTransformerPunc "AliCTTransformerPunc")

###### 其他说明：

测试用例：FireRedASR.Examples。
测试CPU：Intel(R) Core(TM) i7-10750H CPU @ 2.60GHz   2.59 GHz
支持平台：
Windows 7 SP1或更高版本,
macOS 10.13 (High Sierra) 或更高版本,ios等，
Linux 发行版（需要特定的依赖关系，详见.NET 6支持的Linux发行版列表），
Android（Android 5.0 (API 21) 或更高版本）。

引用参考
----------
[1] https://github.com/FireRedTeam/FireRedASR
[2] https://github.com/FireRedTeam/FireRedASR2S
