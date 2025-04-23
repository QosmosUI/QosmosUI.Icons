// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSvelteLine : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19.8001 3.77035C17.9455 0.859147 14.082 0.00263458 11.1708 1.85727L6.11044 5.08107C3.23141 6.91521 2.36191 10.714 4.13686 13.6135C2.93471 15.5852 2.87555 18.1496 4.20064 20.2296C6.05528 23.1408 9.91876 23.9973 12.83 22.1427L17.8903 18.9189C20.7693 17.0847 21.6388 13.2859 19.8639 10.3865C21.0656 8.41543 21.1254 5.85071 19.8001 3.77035ZM18.448 8.77425C17.6282 8.11539 16.6628 7.68286 15.6505 7.49851C15.6882 7.26497 15.6437 7.01723 15.5066 6.80202C15.2099 6.33623 14.5917 6.19918 14.1259 6.49593L9.06558 9.71973C8.59979 10.0165 8.46275 10.6346 8.75949 11.1004C9.05623 11.5662 9.67439 11.7033 10.1402 11.4065L12.2487 10.0633C14.2283 8.8021 16.8554 9.38453 18.1166 11.3641C19.3778 13.3438 18.7953 15.9709 16.8157 17.2321L11.7554 20.4559C9.77574 21.717 7.14858 21.1346 5.88742 19.155C5.11002 17.9347 5.03292 16.4671 5.55276 15.2257C6.37258 15.8846 7.33791 16.3171 8.35026 16.5014C8.31252 16.735 8.35701 16.9827 8.49412 17.1979C8.79086 17.6637 9.40902 17.8008 9.87481 17.504L14.9352 14.2802C15.401 13.9835 15.538 13.3653 15.2413 12.8995C14.9445 12.4337 14.3264 12.2967 13.8606 12.5934L11.7521 13.9367C9.77247 15.1978 7.1453 14.6154 5.88415 12.6358C4.62299 10.6562 5.20542 8.02901 7.18504 6.76786L12.2454 3.54406C14.225 2.2829 16.8522 2.86533 18.1133 4.84495C18.8906 6.06498 18.9681 7.5324 18.448 8.77425Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
