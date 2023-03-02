public class Message
{
    public string Text { get; set; }
    public int SenderID { get; set; }
    public int ReceiverID { get; set; }
    public DateTime Time { get; set; }

    public Message(string text, int sender, int receiver, DateTime time)
    {
        Text = text;
        SenderID = sender;
        ReceiverID = receiver;
        Time = time;
    }

    public override string ToString()
    {   return $"Sender: {SenderID}, Text: {Text}, Time: {Time}";
        //return $"Text: {Text}, Sender: {SenderID}, Receiver: {ReceiverID}, Time: {Time}";
    }
}