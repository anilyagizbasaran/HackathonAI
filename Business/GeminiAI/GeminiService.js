// src/services/GeminiService.js
const { GoogleGenerativeAI, HarmCategory, HarmBlockThreshold } = require("@google/generative-ai");
const { GoogleAIFileManager } = require("@google/generative-ai/server");

class GeminiService {
    constructor(apiKey) {
        this.genAI = new GoogleGenerativeAI(apiKey);
        this.fileManager = new GoogleAIFileManager(apiKey);
    }

    async uploadToGemini(path, mimeType) {
        const uploadResult = await this.fileManager.uploadFile(path, { mimeType, displayName: path });
        return uploadResult.file;
    }

    async waitForFilesActive(files) {
        for (const file of files) {
            let status = await this.fileManager.getFile(file.name);
            while (status.state === "PROCESSING") {
                await new Promise((resolve) => setTimeout(resolve, 10000));
                status = await this.fileManager.getFile(file.name);
            }
            if (status.state !== "ACTIVE") throw Error(`File ${file.name} failed to process`);
        }
    }

    async generateSummary(chatConfig, files) {
        const model = this.genAI.getGenerativeModel({
            model: "gemini-1.5-pro",
            systemInstruction: "Summarize the transcribed video content",
        });

        await this.waitForFilesActive(files);
        const chatSession = model.startChat(chatConfig);

        return chatSession;
    }
}

module.exports = GeminiService;
