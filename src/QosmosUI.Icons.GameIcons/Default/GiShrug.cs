// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiShrug : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M256 29c-11.642 0-22.985 7.432-32.006 21.607C214.974 64.783 209 85.247 209 108s5.973 43.217 14.994 57.393C233.014 179.568 244.358 187 256 187s22.985-7.432 32.006-21.607C297.026 151.217 303 130.753 303 108s-5.973-43.217-14.994-57.393C278.986 36.432 267.642 29 256 29zm-80 131c-32 0-48 144-48 144 0-16-16-64-32-96-16 0-76.002 16-76 26v22l60-16s32 128 48 128 48-112 48-112l16 234h128l16-234s32 112 48 112 48-128 48-128l60 16v-22c.027-10-60-26-76-26-16 32-32 80-32 96 0 0-16-144-48-144 0 0-10.902.02-25.727 1.74-2.092 4.725-4.453 9.187-7.082 13.317C291.945 192.73 275.287 205 256 205c-19.286 0-35.944-12.27-47.19-29.943-2.63-4.13-4.99-8.592-7.083-13.317C186.902 160.02 176 160 176 160z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
