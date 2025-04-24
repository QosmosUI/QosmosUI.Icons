// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLinkerd : ComponentBase
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
		builder.AddAttribute(15, "d", "M22.329 5.04v9.034l1.666.964V6.004l-1.666-.964ZM0 15.038l1.666-.964V5.04L0 6.004v9.034Zm8.165-.089 7.665 4.424V17.45l-7.176-4.142-.489.282v1.359Zm8.105 6.989-8.105-4.681v1.923l2.164 1.25-2.604 1.503a.263.263 0 0 0 0 .454l1.27.737 3-1.73 3 1.73 1.27-.737c.178-.093.178-.35.005-.449Zm6.059-11.511v8.012c0 .202.218.331.396.227l1.142-.657a.267.267 0 0 0 .133-.228V9.468l-1.671.959Zm-3.271 10.354 1.072-.623a.39.39 0 0 0 .198-.341v-8.233l-1.666.963v8.012c0 .198.218.326.396.222Zm-4.063 2.348 1.537-.885a.265.265 0 0 0 .134-.227v-8.318l-1.671.964v8.466Zm-7.532-.89L9 23.124v-8.461l-1.666-.964v8.313c0 .094.05.183.129.227Zm-3.598-2.076 1.072.623a.265.265 0 0 0 .396-.227v-8.017l-1.666-.963v8.238c0 .144.074.277.198.346ZM.198 18.048l1.072.623a.265.265 0 0 0 .396-.228v-8.016L0 9.468v8.239c0 .138.074.267.198.341ZM23.995 6.004l-1.666-.964-3 1.73-1.996-1.152 2.604-1.502a.264.264 0 0 0 0-.455l-1.077-.623a.403.403 0 0 0-.395 0l-2.803 1.616-1.996-1.151L16.27 2a.263.263 0 0 0 0-.454L15.193.923a.405.405 0 0 0-.396 0l-2.802 1.616L9.193.923a.405.405 0 0 0-.396 0l-1.077.623a.263.263 0 0 0 0 .454l14.6 8.432 1.665-.964-3-1.73 3.01-1.734ZM5.135 3.038l-1.072.623a.264.264 0 0 0 0 .455l14.599 8.431 1.666-.963L5.53 3.038a.403.403 0 0 0-.395 0ZM0 6.004l3 1.729-3 1.735 1.671.959 2.995-1.73 2.001 1.157-3 1.73 1.666.963 3-1.734 1.996 1.156-3 1.73L9 14.663l2.995-1.735 3 1.735 1.666-.964L1.666 5.04 0 6.004Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
