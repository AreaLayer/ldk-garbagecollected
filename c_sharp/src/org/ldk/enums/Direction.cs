namespace org { namespace ldk { namespace enums {/**
 * The side of a channel that is the [`IntroductionNode`] in a blinded path. [BOLT 7] defines which
 * nodes is which in the [`ChannelAnnouncement`] message.
 * 
 * [BOLT 7]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-channel_announcement-message
 * [`ChannelAnnouncement`]: crate::ln::msgs::ChannelAnnouncement
 */
public enum Direction {
	/**
	 * The lesser node id when compared lexicographically in ascending order.
	 */
	LDKDirection_NodeOne,
	/**
	 * The greater node id when compared lexicographically in ascending order.
	 */
	LDKDirection_NodeTwo,
}} } }
