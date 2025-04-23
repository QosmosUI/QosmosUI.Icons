// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiWaterPercentLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M7.05025 8.04673L12 3.09698L16.9497 8.04673C19.6834 10.7804 19.6834 15.2126 16.9497 17.9462C14.2161 20.6799 9.78392 20.6799 7.05025 17.9462C4.31658 15.2126 4.31658 10.7804 7.05025 8.04673ZM18.364 6.63252L12 0.268555L5.63604 6.63252C2.12132 10.1472 2.12132 15.8457 5.63604 19.3604C9.15076 22.8752 14.8492 22.8752 18.364 19.3604C21.8787 15.8457 21.8787 10.1472 18.364 6.63252ZM16.2427 10.1714L14.8285 8.75718L7.7574 15.8282L9.17161 17.2425L16.2427 10.1714ZM8.11095 11.232C8.69674 11.8178 9.64648 11.8178 10.2323 11.232C10.8181 10.6463 10.8181 9.69652 10.2323 9.11073C9.64648 8.52494 8.69674 8.52494 8.11095 9.11073C7.52516 9.69652 7.52516 10.6463 8.11095 11.232ZM15.8891 16.8889C15.3033 17.4747 14.3536 17.4747 13.7678 16.8889C13.182 16.3031 13.182 15.3534 13.7678 14.7676C14.3536 14.1818 15.3033 14.1818 15.8891 14.7676C16.4749 15.3534 16.4749 16.3031 15.8891 16.8889Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
