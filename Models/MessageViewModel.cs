namespace suivi_abonnement.Models
{
    public class MessageViewModel
    {
        public int? ReceiverId { get; set; } // Id du destinataire
        public List<User> Users { get; set; } // Liste des utilisateurs
        public List<User> adminUser {get; set; }
        public int CurrentUserId { get; set; } // Id de l'utilisateur actuel
        public List<Message> Messages { get; set; } // Liste des messages

        public MessageViewModel()
        {
            Messages = new List<Message>();
        }
    }
}