# FireRedAsr
c# library for decoding FireRedASR's AED-L Model，used in speech recognition (ASR)

##### 简介：
这是一个用于解码 FireRedASR's AED-L onnx 模型的c#库，使用c#编写，基于.net6.0，支持在多平台（包括windows、linux、android、macos、ios等）编译、调用。

##### 支持的模型（ONNX）
| 模型名称  |  类型 |  支持语言  | 下载地址  |
| ------------ | ------------ | ------------ | ------------ |
|  fireredasr-aed-large-zh-en-onnx-offline-20250124 | 非流式  | 中文、英文  |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr-aed-large-zh-en-onnx-offline-20250124 "modelscope") |

##### 使用方法
1.下载模型到FireRedAsr.Examples项目文件夹，设置模型文件为“如果较新则复制”
2.使用vs2022加载项目，运行FireRedAsr.Examples示例

引用参考
----------
[1] https://github.com/FireRedTeam/FireRedASR
