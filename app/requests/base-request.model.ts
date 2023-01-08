export default abstract class BaseRequest {

    async validate(): Promise<boolean> {
        return true;
    }
}