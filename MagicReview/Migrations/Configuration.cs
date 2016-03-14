namespace MagicReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using MagicReview.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MagicReview.Models.CardDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MagicReview.Models.CardDB";
        }

        protected override void Seed(MagicReview.Models.CardDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.cards.AddOrUpdate(c => c.name,
                new InstantSorcery
                {
                    ID="OGW020",
                    name="Immolating Glare",
                    conManaCost=2,
                    manaCost="1w",
                    isInstant=true,
                    rulesText="Destroy target attacking creature.",
                    //keywordActions= {AppEnums.KeywordAction.Destroy},
                    flavorText="'The sun can warm your skin or blister it, nurture your crops or wither them, light your path or blind you. " + 
                        "She is a fickle friend, but a far worse enemy.' - Nazra of the Stone Havens"
                },

                new Creature
                {
                    ID="OGW145",
                    name="Tajuru Pathwarden",
                    conManaCost=5,
                    manaCost="4g",
                    isLegendary=false,
                    isArtifact=false,
                    isEnchantment=false,
                    power=5,
                    toughness=4,
                    rulesText="Vigilance, Trample",
                    //keywordAbilities = {AppEnums.KeywordAbility.Vigilance, AppEnums.KeywordAbility.Trample},
                    flavorText="'My people blazed these pathways long ago, before the Eldrazi came. We will ride them long after the Eldrazi are gone.'"
                }

                );
            context.users.AddOrUpdate(u => u.username,
                new User
                {
                    ID=1,
                    username="ManaLeak",
                    password="BlackLotus"
                },

                new User
                {
                    ID=2,
                    username="CounterBounce",
                    password="MoxJet"
                }

                );
            context.reviews.AddOrUpdate(r => r.ID,
                new Review
                {
                    ID=1,
                    cardID="OGW020",
                    userID=1,
                    reviewText="5/7 it's okay"
                },

                new Review
                {
                    ID=2,
                    cardID="OGW145",
                    userID=2,
                    reviewText="A good midgame card that's easy to splash."
                }

                );
        }
    }
}
