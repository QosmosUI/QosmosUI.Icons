// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCrowdsource : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.0002 1.7719c-1.1291 0-2.0448.9157-2.0448 2.0448s.9157 2.0468 2.0448 2.0468 2.0448-.9177 2.0448-2.0468-.9157-2.0448-2.0448-2.0448zM7.3637 5.4534c-1.1291 0-2.0448.9177-2.0448 2.0468S6.2346 9.545 7.3637 9.545s2.0448-.9157 2.0448-2.0448-.9157-2.0468-2.0448-2.0468zm9.2731 0c-1.1291 0-2.0448.9177-2.0448 2.0468s.9157 2.0448 2.0448 2.0448 2.0448-.9157 2.0448-2.0448-.9157-2.0468-2.0448-2.0468zM1.3463 7.6369a1.3178 1.3178 0 0 0-.9296.3594c-.495.465-.5563 1.2308-.1445 1.7695.6607.864 1.9925 2.604 2.6522 3.4647a5.401 5.401 0 0 1 1.1113 3.2831c0 1.5191.7096 2.9662 1.9491 3.8416.767.5425 1.6144.9821 2.5155 1.3002v-3.9329c0-.5925.1911-1.1709.4717-1.6529-.1028-.9491-.5204-1.8117-1.1982-2.4953L2.3424 8.1056c-.2617-.2888-.6256-.4685-.9961-.4687zm21.3098 0a1.3178 1.3178 0 0 0-.916.3906l-4.5447 4.574-.9687.9746c-.6773.682-1.0948 1.5476-1.1987 2.4937.2654.4549.4544.9933.4722 1.5491v4.0389a10.2809 10.2809 0 0 0 2.5155-1.3027c1.2382-.8755 1.9491-2.3226 1.9491-3.8416a5.4125 5.4125 0 0 1 1.1113-3.285c.5943-.778 2.0414-2.6661 2.6522-3.4628.4118-.5386.3491-1.3045-.1445-1.7695a1.3143 1.3143 0 0 0-.9277-.3593zm-10.6559 1.498c-1.1291 0-2.0448.9177-2.0448 2.0468s.9157 2.0448 2.0448 2.0448 2.0448-.9157 2.0448-2.0448c.0001-1.1291-.9157-2.0468-2.0448-2.0468zm.002 5.7283c-1.6582 0-3.0018 1.2802-3.0018 2.8593v4.0916c.9518.2673 1.9567.414 2.9999.414s2.0481-.1454 2.9999-.414v-4.1795c-.0492-1.5382-1.3712-2.7714-2.998-2.7714z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
