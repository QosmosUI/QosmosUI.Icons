// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPinetwork : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 .002c-6.628 0-12 5.371-12 12 0 6.628 5.372 11.996 12 11.996s12-5.371 12-12C24 5.37 18.624.002 12 .002zm0 1.719c5.679 0 10.281 4.602 10.281 10.281S17.68 22.283 12 22.283 1.719 17.681 1.719 12.002 6.32 1.721 12 1.721zM9.102 5.943c-.123 0-.227.1-.227.227v1.139c0 .122.1.226.227.226h1.56a.225.225 0 0 0 .227-.226v-1.14c0-.121-.1-.226-.227-.226h-1.56zm3.685 0c-.122 0-.226.1-.226.227v1.139c0 .122.1.226.226.226h1.559a.228.228 0 0 0 .226-.226v-1.14c0-.121-.1-.226-.226-.226h-1.559zm3.219 1.407v1.19H7.352c-1.895.026-1.975 2.042-1.975 2.042v1.461H7.43l.008-1.447h1.398v7.574c-.005.457.451.285.451.285l1.461-.516c.23-.099.186-.308.186-.308v-7.022h1.591v7.641c.014.357.366.213.366.213l1.591-.565c.14-.076.118-.195.118-.195l-.022-7.062 1.527-.04c1.909-.027 1.963-2.103 1.963-2.103V7.35h-2.062");
		builder.CloseElement();
		builder.CloseElement();
    }
}
