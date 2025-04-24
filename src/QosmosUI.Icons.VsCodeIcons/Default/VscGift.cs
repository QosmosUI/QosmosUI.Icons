// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscGift : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M13.5 4h-1.6c.1-.4.1-.8.1-1.2-.1-.3-.2-.6-.4-.9-.2-.3-.4-.5-.7-.6-.3-.1-.6-.3-.9-.3-.3 0-.6 0-.9.2-.7.2-1.2.7-1.6 1.3-.4-.6-.9-1.1-1.6-1.3-.3-.1-.6-.2-.9-.2-.3 0-.6.1-.9.3-.3.1-.5.3-.7.6-.2.2-.3.6-.4.9 0 .4 0 .8.1 1.2H1.5l-.5.5v9l.5.5h12l.5-.5v-9l-.5-.5zM7 13H2V5h5v8zm0-9H4v-.2c-.1-.3-.1-.5-.1-.8.1-.2.1-.4.3-.5.1-.2.3-.3.5-.4.1-.1.3-.1.5-.1s.4 0 .6.1c.3.1.6.3.8.6.2.3.4.6.4 1V4zm1-.3c0-.4.2-.7.4-1 .2-.3.5-.5.8-.6.2-.1.4-.1.6-.1.2 0 .4 0 .6.1.2.1.3.2.5.4.1.1.1.3.2.5 0 .3 0 .5-.1.8 0 .1 0 .1-.1.2H8v-.3zm5 9.3H8V5h5v8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
