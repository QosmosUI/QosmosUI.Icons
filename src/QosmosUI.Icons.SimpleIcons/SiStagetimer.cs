// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiStagetimer : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12.127 2.639c0 .821.662 1.475 1.464 1.644a7.832 7.832 0 0 1 6.201 7.666c0 4.326-3.499 7.833-7.815 7.833a7.767 7.767 0 0 1-3.932-1.062c-.716-.419-1.66-.372-2.207.253l-.794.906c-.549.625-.491 1.586.196 2.053A11.946 11.946 0 0 0 11.977 24C18.617 24 24 18.605 24 11.949 24 5.86 19.495.826 13.644.013c-.829-.116-1.517.571-1.517 1.411v1.215ZM2.01 15.376c-.8.27-1.236 1.135-.866 1.886.255.518.546 1.016.871 1.492.473.693 1.449.752 2.085.202l.921-.797c.636-.551.686-1.502.26-2.224l-.035-.06c-.419-.726-1.277-1.158-2.077-.889l-1.159.39Zm-.322-1.384c-.807.162-1.6-.369-1.658-1.198-.04-.571-.04-1.143 0-1.714.058-.829.851-1.36 1.658-1.198l1.168.233c.807.162 1.316.957 1.312 1.788v.068c.004.831-.505 1.626-1.312 1.787l-1.168.234Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
