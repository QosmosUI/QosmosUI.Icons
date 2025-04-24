// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPortainer : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.504 0v1.023l-.01-.015-6.106 3.526H3.417v.751h5.359v3.638h1.942V5.284h1.786v10.416c.027 0 .54-.01.751.091V5.285h.531v10.608c.293.147.55.312.751.54V5.286h6.046v-.75h-1.267l-6.061-3.5V0zm0 1.87v2.664H7.889zm.751.031l4.56 2.633h-4.56zM9.142 5.285h1.21v1.686h-1.21zm-4.736 2.73v1.951h1.942v-1.95zm2.19 0v1.951h1.941v-1.95zm-2.19 2.171v1.951h1.942v-1.95zm2.19 0v1.951h1.941v-1.95zm2.18 0v1.951h1.942v-1.95zM4.36 12.43a3.73 3.73 0 00-.494 1.851c0 1.227.604 2.308 1.52 2.986.239-.064.477-.1.724-.11.1 0 .165.01.266.019.284-1.191 1.383-1.988 2.665-1.988.724 0 1.438.201 1.924.668.229-.476.302-1.007.302-1.575 0-.65-.165-1.292-.494-1.85zm4.828 3.16c-1.21 0-2.226.844-2.492 1.97a.922.922 0 00-.275-.009 2.559 2.559 0 00-2.564 2.556 2.565 2.565 0 003.096 2.5A2.579 2.579 0 009.233 24c.862 0 1.622-.43 2.09-1.081a2.557 2.557 0 004.186-1.97c0-.567-.193-1.099-.504-1.52a2.557 2.557 0 00-3.866-2.94 2.574 2.574 0 00-1.951-.898z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
